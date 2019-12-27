using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Standard_Chris;
namespace Fismo_Connect_SOW
{
    public partial class ConnectionOptions : Form
    {
        private System.IO.Ports.SerialPort nPort;
        private bool validSerialPortSet = false;

        public ConnectionOptions()
        {
            InitializeComponent();
        }
        public bool GetValidSerialPortSet()
        {
            return validSerialPortSet;
        }

        public System.IO.Ports.SerialPort GetOpenSerialPort()
        {
            return nPort;
        }

        private void ConnectionOptions_Load(object sender, EventArgs e)
        {
            this.RefreshCOMPortList();

            //set available rates
            this.comboBoxBaudRate.Items.Clear();

            this.comboBoxBaudRate.Items.Add("110");
            this.comboBoxBaudRate.Items.Add("300");
            this.comboBoxBaudRate.Items.Add("600");
            this.comboBoxBaudRate.Items.Add("1200");
            this.comboBoxBaudRate.Items.Add("2400");
            this.comboBoxBaudRate.Items.Add("4800");
            this.comboBoxBaudRate.Items.Add("9600");
            this.comboBoxBaudRate.Items.Add("14400");
            this.comboBoxBaudRate.Items.Add("19200");
            this.comboBoxBaudRate.Items.Add("38400");
            this.comboBoxBaudRate.Items.Add("57600");
            this.comboBoxBaudRate.Items.Add("115200");
            this.comboBoxBaudRate.Items.Add("230400");
            this.comboBoxBaudRate.Items.Add("460800");
            this.comboBoxBaudRate.Items.Add("921600");

            //set default at
            this.comboBoxBaudRate.SelectedIndex = 11;
        }

        void RefreshCOMPortList()
        {
            //update the COM port combo box
            string[] portsFound = System.IO.Ports.SerialPort.GetPortNames();

            this.comboBoxComPort.Items.Clear();

            for (int i = 0; i < portsFound.Length; i++)
            {
                this.comboBoxComPort.Items.Add(portsFound[i]);
            }

            if (portsFound.Length > 0)
            {
                this.comboBoxComPort.SelectedIndex = 0;
            }
        }

        private void labelAutoDetect_Click(object sender, EventArgs e)
        {
            String comPortResult = "";
            int comPortsFound = DeviceSupportFunctions.FindSerialPortFromVenderAndProductPID("", "", ref comPortResult);

            if (comPortsFound == 0)
            {
                //show a pop up message box
                
                string message = "No USB Serial COM Ports found ";
                string caption = "Error Device Not Found";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                //Show
                DialogResult MessageResult = MessageBox.Show(message, caption, buttons);
                if (MessageResult == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }

            }
            else if (comPortsFound == 1)
            {
                //AOK

                //set the details
            }
            else
            {
                //Error
                string message = "Mulitple("+comPortsFound+") USB Serial COM Ports found, only connect one device ";
                string caption = "Error To Manu Devices";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                //Show
                DialogResult MessageResult = MessageBox.Show(message, caption, buttons);
                if (MessageResult == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.nPort = new System.IO.Ports.SerialPort();

            try
            {

                int baudRate = System.Convert.ToInt32(this.comboBoxBaudRate.Text);

                nPort.PortName = this.comboBoxComPort.Text;
                nPort.BaudRate = baudRate;

                nPort.Open();

                //the user set a valid port
                this.validSerialPortSet = true;

                //close UI
                this.Close();
            }
            catch(Exception ex)
            {
                //do usefuil things to help the user...
            }

            

        }

        private void labelRefreshList_Click(object sender, EventArgs e)
        {
            this.RefreshCOMPortList();
        }
    }
}
