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
    public partial class MainApp : Form
    {
        //IDs used for report progress events
        public enum BGW_STATES : int
        {
            BGW_MONIOR_OUTPUT = 0xFF,
            BGW_TERM_RX_UPDATE,
        }

        public MainApp()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateStatusTerminal(String str,bool showTimeStamp)
        {
            this.richTextBoxStatus.AppendText("#" + 
                ((showTimeStamp == true)?SupportFunctions.GetTimeStampShort():"") + ": " + str + "\n");
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            //runs on startup
            this.toolStripStatusLabel_version.Text = ApplicationDefines.Get_Version_String();
            this.toolStripStatusLabel_author.Text = ApplicationDefines.Get_Author_String();

            this.UpdateStatusTerminal("Application Started",true);

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            if (this.serialPort1.IsOpen == true)
            {
                this.UpdateStatusTerminal("Process stopped", true);
                this.backgroundWorkerDevice.CancelAsync();
                this.connectToolStripMenuItem.Text = "Connect";

                this.serialPort1.Close();

                //disable the interface
                this.splitContainer1.Enabled = false;
            }
            else
            {
                ConnectionOptions cOPtions = new ConnectionOptions();

                cOPtions.ShowDialog();

                if (cOPtions.GetValidSerialPortSet() == true)
                {
                    //gets us an alreayd open port
                    this.serialPort1 = cOPtions.GetOpenSerialPort();

                    //Start BGW
                    this.backgroundWorkerDevice.RunWorkerAsync();

                    this.UpdateStatusTerminal("Process Started, COM: "+this.serialPort1.PortName +" open @ "+this.serialPort1.BaudRate+" baud", true);

                    this.connectToolStripMenuItem.Text = "Disconnect";

                    //enable the interface
                    this.splitContainer1.Enabled = true;
                }
            }
        }

        private void backgroundWorkerDevice_DoWork(object sender, DoWorkEventArgs e)
        {
            this.backgroundWorkerDevice.ReportProgress((int)BGW_STATES.BGW_MONIOR_OUTPUT,"Device BGW Started");

            ProtocolCommunicationsTiger nProtoCommsTiger = new ProtocolCommunicationsTiger();

            DateTime lastRXReportTime = DateTime.Now;

            while (!this.backgroundWorkerDevice.CancellationPending)
            {

                List<byte> dataIn = new List<byte>();

                //look for data from Device
                if (serialPort1.BytesToRead > 0)
                {
                    int nByte = this.serialPort1.ReadByte();

                    bool result = nProtoCommsTiger.BuildFrame((byte)nByte);

                    dataIn.Add((byte)nByte);

                    if (result == true)
                    {
                        //got a valid frame
                        byte[] nData = nProtoCommsTiger.GetFrameAsByteArray();

                        this.backgroundWorkerDevice.ReportProgress((int)BGW_STATES.BGW_MONIOR_OUTPUT, "New Frame:" +
                            SupportFunctions.ByteArrayToString(nData, nData.Count()));
                    }

                    //update status term every 100ms
                    DateTime nTime = DateTime.Now;
                    TimeSpan lastReportTimePassed = nTime.Subtract(lastRXReportTime);

                    if (lastReportTimePassed.TotalMilliseconds >= 100)
                    {
                        String rxData = SupportFunctions.ByteListToString(dataIn);

                        dataIn.Clear();

                        this.backgroundWorkerDevice.ReportProgress((int)BGW_STATES.BGW_TERM_RX_UPDATE, rxData);

                    }

                }
                else
                {
                    //CPU Rest
                    System.Threading.Thread.Sleep(10);
                }
            }
        }

        private void backgroundWorkerDevice_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case (int)BGW_STATES.BGW_MONIOR_OUTPUT:
                    this.UpdateStatusTerminal((String)e.UserState,true);
                    break;
                case (int)BGW_STATES.BGW_TERM_RX_UPDATE:
                    this.UpDateRawRxTerminal((String)e.UserState);
                    break;
            }
        }

        private void backgroundWorkerDevice_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.UpdateStatusTerminal("Device BGW Completed", true);
        }

        private void buttonManualSend_Click(object sender, EventArgs e)
        {
            //Manual send

            //get input
            List<byte> inputData = SupportFunctions.ASCIIHexStringToByteList(this.richTextBoxManualInput.Text);

            if (inputData == null)
            {
                this.UpdateStatusTerminal("Input Error - check input data", true);
                return;
            }

            if (this.checkBoxApplyTigerProtocol.Checked == true)
            {
                //apply Tiger
                inputData = ProtocolCommunicationsTiger.GeneratePacketForTx(inputData);
            }

            //Send
            this.SendToOpenSerialPort(inputData);

        }

        private bool SendToOpenSerialPort(List<byte> dataToSend)
        {
            this.UpDateRawTxTerminal(dataToSend);
            try
            {
                this.serialPort1.Write(SupportFunctions.ConvertByteListToByteArray(dataToSend), 0, dataToSend.Count);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
                this.UpdateStatusTerminal("TX Error - check connections", true);
                return false;
            }

            return true;
        }

        private void UpDateRawTxTerminal(List<byte> dataToSend)
        {
            this.richTextBoxTX.AppendText(SupportFunctions.ByteListToString(dataToSend) + "\n");
        }

        private void UpDateRawRxTerminal(List<byte> dataToSend)
        {
            this.richTextBoxRX.AppendText(SupportFunctions.ByteListToString(dataToSend));
        }
        private void UpDateRawRxTerminal(string dataToSend)
        {
            this.richTextBoxRX.AppendText(dataToSend);
        }


        private void MainApp_Shown(object sender, EventArgs e)
        {
            this.connectToolStripMenuItem_Click(sender, e);
        }

        private void labelClearMonitor_Click(object sender, EventArgs e)
        {
            this.richTextBoxStatus.Clear();
        }

        private void labelRawCommsRxClear_Click(object sender, EventArgs e)
        {
            this.richTextBoxRX.Clear();
        }

        private void labelRawCommsTxClear_Click(object sender, EventArgs e)
        {
            this.richTextBoxTX.Clear();
        }
    }
}
