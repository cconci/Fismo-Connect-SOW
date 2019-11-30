using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fismo_Connect_SOW
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            //runs on startup
            this.toolStripStatusLabel_version.Text = ApplicationDefines.Get_Version_String();
            this.toolStripStatusLabel_author.Text = ApplicationDefines.Get_Author_String();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            ConnectionOptions cOPtions = new ConnectionOptions();

            cOPtions.ShowDialog();
        }
    }
}
