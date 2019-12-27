using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Standard_Chris;

namespace Fismo_Connect_SOW
{
    class ProtocolCommunicationsTiger
    {
        private const byte SOP = 0x7D;
        private const byte EOP = 0x7E;
        private const byte ESCAPE = 0x7F;

        private List<byte> rxBuffer;
        private bool unslipNextByte;
        private int checksum;

        public ProtocolCommunicationsTiger()
        {
            this.rxBuffer = new List<byte>();
            this.unslipNextByte = false;
            this.checksum = 0;
        }

        public byte[] GetFrameAsByteArray()
        {
            return SupportFunctions.ConvertByteListToByteArray(this.rxBuffer);
        }

        public bool BuildFrame(byte data)
        {

            if (data == SOP)
            {
                //reset buffer
                rxBuffer.Clear();

                this.checksum = 0;//SOP not included in checksum
            }
            else if (data == EOP)
            {
                //process buffer

                //Adjust as we did not know where the buffer was going to end before and added the CS
                this.checksum -= this.rxBuffer.ElementAt(this.rxBuffer.Count - 1);

                byte checkSumCalc = (byte)(((this.checksum ^ 0xFF) + 1) & 0xFF);
                if (checkSumCalc == this.rxBuffer.ElementAt(this.rxBuffer.Count-1))//check the CS
                {
                    return true;
                }
                else
                {
                    rxBuffer.Clear();
                    return false;
                }

            }
            else if (data == ESCAPE)
            {
                this.unslipNextByte = true;
            }
            else
            {
                //add to buffer
                if (this.unslipNextByte == true)
                {
                    byte nValue = UnslipAction((byte)data);

                    rxBuffer.Add(nValue);
                    this.checksum += nValue;

                    this.unslipNextByte = false;
                }
                else
                {
                    rxBuffer.Add(data);
                    this.checksum += data;
                }
            }

            return false;
        }

        //
        //
        //

        public static List<Byte> GeneratePacketForTx(List<Byte> frameData)
        {
            List<Byte> nPacket = new List<Byte>();

            byte checksum = 0;

            //Add STX
            nPacket.Add(SOP);

            for (int a = 0; a < frameData.Count; a++)
            {

                checksum += frameData[a];


                if (SlipByte(frameData[a]) == true)
                {

                    nPacket.Add(ESCAPE);
                    nPacket.Add(SlipAction((byte)(frameData[a])));
                }
                else
                {
                    nPacket.Add(frameData[a]);

                }
            }

            //Add CS
            checksum = (byte)(((checksum ^ 0xFF)+1) & 0xFF);

            if (SlipByte(checksum) == true)
            {
                nPacket.Add(ESCAPE);
                nPacket.Add(SlipAction((byte)checksum));
            }
            else
            {
                nPacket.Add(checksum);
            }

            //Add ETX
            nPacket.Add(EOP);

            return nPacket;
        }

        public static byte SlipAction(byte value)
        {
            return (byte)(value + ESCAPE);
        }

        public static byte UnslipAction(byte value)
        {
            return (byte)(value - ESCAPE);
        }

        public static bool SlipByte(int data)
        {

            switch (data)
            {
                case SOP:
                case EOP:
                case ESCAPE:

                    //slip
                    return true;

                    break;

                default:
                    return false;
                    break;
            }
        }
    }
}
