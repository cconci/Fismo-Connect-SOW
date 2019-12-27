using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Chris
{
    class SupportFunctions
    {
        public static byte[] ConvertByteListToByteArray(List<byte> dataIn)
        {

            byte[] dataOut = new byte[dataIn.Count];

            for (int a = 0; a < dataIn.Count; a++)
            {

                dataOut[a] = (byte)(dataIn.ElementAt(a) & 0xFF);

            }

            return dataOut;

        }

        public static String GetTimeStampShort()
        {

            DateTime cTime = DateTime.Now;
            //YYYYMMDDHHMMSS.mmm
            return cTime.Year.ToString("00") + "" + cTime.Month.ToString("00") + "" + cTime.Day.ToString("00") + "" + cTime.Hour.ToString("00") + "" + cTime.Minute.ToString("00") + "" + cTime.Second.ToString("00") + "." + cTime.Millisecond.ToString("000");
        }

        public static string ByteArrayToString(byte[] data, int dataLen)
        {
            string retVal = "";


            for (int a = 0; a < dataLen; a++)
            {
                retVal += data[a].ToString("X2") + " ";
            }

            return retVal;
        }

        public static string ByteListToString(List<byte> dataIn)
        {
            string retVal = "";


            for (int a = 0; a < dataIn.Count; a++)
            {
                retVal += dataIn[a].ToString("X2") + " ";
            }

            return retVal;
        }

        public static byte[] ASCIIHexStringToByteArray(string asciiHexString)
        {
            string[] splitData = asciiHexString.Split(' ');

            byte[] bytes = new byte[splitData.Length];
            try
            {

                for (int a = 0; a < splitData.Length; a++)
                {
                    bytes[a] = System.Convert.ToByte(splitData[a], 16);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
                return null;//data is not formated correctly 
            }

            return bytes;
        }

        public static List<byte> ASCIIHexStringToByteList(string asciiHexString)
        {
            string[] splitData = asciiHexString.Split(' ');

            List<byte> bytes = new List<byte>();

            try
            {
                for (int a = 0; a < splitData.Length; a++)
                {
                    bytes.Add(System.Convert.ToByte(splitData[a], 16));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
                return null;//data is not formated correctly 
            }

            return bytes;
        }

    }
}
