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
        SerialPort myPort;
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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            myPort = new SerialPort(comboBoxPortSelect.SelectedItem.ToString(), 9600);
            myPort.Open();
            if (myPort.IsOpen.Equals(false))
            {
                MessageBox.Show("ポート開放に失敗しました", "ポート開放エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                buttonScan.Enabled = false;
                comboBoxPortSelect.Enabled = false;
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                buttonSend.Enabled = true;
                myPort.WriteTimeout = 100;
            }
        }

        private void comboBoxPortSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            myPort.Close();
            buttonStop.Enabled = false;
            buttonSend.Enabled = false;
            buttonScan.Enabled = true;
            comboBoxPortSelect.Items.Clear();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                myPort.WriteLine(textBoxSendData.Text);

            }
            catch (TimeoutException)
            {
                MessageBox.Show("送信がタイムアウトしました\r\n接続を確認して下さい", "タイムアウト", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxSendData.Text = "";
        }
    }
}
