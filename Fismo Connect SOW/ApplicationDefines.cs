using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fismo_Connect_SOW
{
    class ApplicationDefines
    {
        public const byte VERSION_MAJOR = 0;
        public const byte VERSION_MINOR = 0;
        public const byte VERSION_REVISION = 1;
        public const byte VERSION_LETTER = (byte)'A';

        //VID_0403+PID_6001
        public const String USB_FISMO_PID = "6001";
        public const String USB_FISMO_VID = "0403";

        public const String AUTHOR = "cconci";


        public static string Get_Version_String()
        {
            string ret = "";

            ret = ApplicationDefines.VERSION_MAJOR.ToString("00")
                    + "." +
                    ApplicationDefines.VERSION_MINOR.ToString("00")
                    + "." +
                    ApplicationDefines.VERSION_REVISION.ToString("00")
                    + "" +
                    ((char)ApplicationDefines.VERSION_LETTER);

            return ret;
        }

        public static string Get_Author_String()
        {
            return AUTHOR;
        }
    }
}
