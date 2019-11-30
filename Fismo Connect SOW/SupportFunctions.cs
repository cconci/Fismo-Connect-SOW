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

    }
}
