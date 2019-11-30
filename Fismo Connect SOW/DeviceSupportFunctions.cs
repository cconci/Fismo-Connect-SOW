using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Standard_Chris
{
    class DeviceSupportFunctions
    {
        /*
        <https://docs.microsoft.com/en-us/dotnet/api/system.management.managementobjectsearcher?view=netframework-4.8> 
        <https://social.msdn.microsoft.com/Forums/windows/en-US/c53b23a4-12c3-43ba-9127-b74450ab874a/how-to-get-more-info-about-port-using-systemioportsserialport?forum=winforms>
        <https://stackoverflow.com/questions/11458835/finding-information-about-all-serial-devices-connected-through-usb-in-c-sharp>
        <https://social.msdn.microsoft.com/Forums/windows/en-US/c53b23a4-12c3-43ba-9127-b74450ab874a/how-to-get-more-info-about-port-using-systemioportsserialport?forum=winforms>
       */

        public static int FindSerialPortFromVenderAndProductPID(String vid, String pid, ref String resultPortName)
        {
            try
            {
                int foundDevices = 0;
                string[] portNames = SerialPort.GetPortNames();
                string sInstanceName = string.Empty;
                string sPortName = string.Empty;

                ManagementObjectCollection mbsList = null;
                //there is a couple of places it could be,
                //ManagementObjectSearcher mbs = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM MSSerial_PortName");
                ManagementObjectSearcher mbs = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity WHERE ClassGuid=\"{4d36e978-e325-11ce-bfc1-08002be10318}\"");

                mbsList = mbs.Get();

                foreach (ManagementObject mo in mbsList)
                {
                    System.Diagnostics.Debug.Print("#"
                        + mo["Name"].ToString() + "|"
                        + mo["Description"].ToString() + "|"
                        + mo["SystemName"].ToString() + "|"
                        + mo["SystemCreationClassName"].ToString() + "|"
                        + mo["Status"].ToString() + "|"

                        + mo["PNPDeviceID"].ToString() + "|"    //VID & PID
                        + mo["CreationClassName"].ToString() + "|"
                        + mo["Caption"].ToString() + "|"
                        //+ mo["Caption"].ToString() + "|"

                        + "\n"
                    );


                    sInstanceName = mo["PNPDeviceID"].ToString();

                    //VID_0403+PID_6001
                    if (sInstanceName.IndexOf("VID_" + vid) > -1
                        && sInstanceName.IndexOf("PID_" + pid) > -1)
                    {
                        //Name like 'USB Serial Port (COM9)'
                        sPortName = mo["Name"].ToString();

                        //trim
                        sPortName = sPortName.Split('(')[1].Split(')')[0];

                        System.Diagnostics.Debug.Print("found a device:" + sPortName);
                        //found One
                        foundDevices++;
                        resultPortName = sPortName;
                    }
                }


                return foundDevices;
            }
            catch (Exception ex)
            {
                //Error
                System.Diagnostics.Debug.Print("ERROR:" + ex.ToString());

                return 0;
            }
        }

    }
}
