using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace BT_SCI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            comboBoxPortSelect.Enabled = true;
            foreach (var port in SerialPort.GetPortNames())
            {
                comboBoxPortSelect.Items.Add(port);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
