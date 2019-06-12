using System;
using System.Windows.Forms;
using UsrCommunication;
using UsrConsole;
using NLog;
using System.Drawing;

namespace WindowsForms串口
{

    public partial class Form1 : Form
    {

        SerialClass SerialPort1 = new SerialClass();
        UsrConsoleClass usrconsole1 = new UsrConsoleClass();
        private static Logger logger = LogManager.GetCurrentClassLogger();  //Logger对象代表与当前类相关联的日志消息的来源 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Startup();
        }

        private void SerialPort1_ComReceiveDataEvent(object sender, SerialPortEventArgs e)
        {
            if(this.InvokeRequired)
            {
                try
                {
                    Invoke(new Action<Object, SerialPortEventArgs>(SerialPort1_ComReceiveDataEvent), sender, e);
                }
                catch (System.Exception)
                {
                    //disable form destroy exception
                }
                return;
            }
            if (rdoHexReceived.Checked)
            {
                txtReceived.Text += UsrMethod.UsrConversion.Byte2HexString(e.receiveBytes);
            }
            else
            {
                txtReceived.Text += UsrMethod.UsrConversion.Byte2String(e.receiveBytes);
            }
            tstlblReceiveCounter.Text = "R: " + SerialPort1.receiveBytesCount.ToString();
        }
        private void SerialPort1_ComComOpenEvent(object sender, SerialPortEventArgs e)
        {
            if (this.InvokeRequired)
            {
                try
                {
                    Invoke(new Action<Object, SerialPortEventArgs>(SerialPort1_ComComOpenEvent), sender, e);
                }
                catch (System.Exception)
                {
                    //disable form destroy exception
                }
                return;
            }
            tstlblPortStatus.Text = SerialPort1.GetSerialPortStatus();
            this.Text = SerialPort1.GetSerialPortStatus();
            //statusStrip1.BackColor = Color.Red;
            tstlblConnectionSTAT.BackColor = Color.Red;
        }
        private void SerialPort1_ComComCloseEvent(object sender, SerialPortEventArgs e)
        {
            if (this.InvokeRequired)
            {
                try
                {
                    Invoke(new Action<Object, SerialPortEventArgs>(SerialPort1_ComComCloseEvent), sender, e);
                }
                catch (System.Exception)
                {
                    //disable form destroy exception
                }
                return;
            }
            tstlblPortStatus.Text = SerialPort1.GetSerialPortStatus();
            this.Text = SerialPort1.GetSerialPortStatus();
            //statusStrip1.BackColor = btnRefresh.BackColor;
            tstlblConnectionSTAT.BackColor = btnRefresh.BackColor;
        }

        private void BtnSendData_Click(object sender, EventArgs e)
        {
            if (rdoHexSend.Checked)
            {
                SerialPort1.SerialPortSend(UsrMethod.UsrConversion.HexString2Byte(txtSend.Text));
            }
            else
            {
                SerialPort1.SerialPortSend(txtSend.Text);
            }
            tstlblSendCounter.Text = "S: "+ SerialPort1.sendBytesCount.ToString();
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void TmrCurrent_Tick(object sender, EventArgs e)
        {
            tstlblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnClearReceivedData_Click(object sender, EventArgs e)
        {
            txtReceived.Clear();
            SerialPort1.receiveBytesCount = 0;
        }

        private void BtnClearSendData_Click(object sender, EventArgs e)
        {
            txtSend.Clear();
            SerialPort1.receiveBytesCount = 0;
        }
        private void Startup()
        {
            //***************************************************************
            rdoSrtingSend.Select();
            rdoStringReceived.Select();
            //***************************************************************
            foreach (string str1 in SerialClass.GetSerialPropertyValue(SerialClass.SerialProperty.PortName))
            {
                cmbPortName.Items.Add(str1);
            }
            foreach (string str1 in SerialClass.GetSerialPropertyValue(SerialClass.SerialProperty.BaudRate))
            {
                cmbBaudRate.Items.Add(str1);
            }
            foreach (string str1 in SerialClass.GetSerialPropertyValue(SerialClass.SerialProperty.DataBits))
            {
                cmbDataBits.Items.Add(str1);
            }
            foreach (string str1 in SerialClass.GetSerialPropertyValue(SerialClass.SerialProperty.StopBits))
            {
                cmbStopBits.Items.Add(str1);
            }
            foreach (string str1 in SerialClass.GetSerialPropertyValue(SerialClass.SerialProperty.Parity))
            {
                cmbParity.Items.Add(str1);
            }
            foreach (string str1 in SerialClass.GetSerialPropertyValue(SerialClass.SerialProperty.HandShake))
            {
                cmbHandShaking.Items.Add(str1);
            }
            //***************************************************************
            cmbPortName.SelectedIndex = 0;
            cmbBaudRate.SelectedIndex = 1;
            cmbDataBits.SelectedIndex = 0;
            cmbStopBits.SelectedIndex = 1;
            cmbParity.SelectedIndex = 0;
            cmbHandShaking.SelectedIndex = 0;
            //***************************************************************
            btnSendData.Enabled = false;
            tstlblPortStatus.Text = SerialPort1.GetSerialPortStatus();
            this.Text = SerialPort1.GetSerialPortStatus();
            SerialPort1.ComOpenEvent += SerialPort1_ComComOpenEvent;
            SerialPort1.ComCloseEvent += SerialPort1_ComComCloseEvent;

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            cmbPortName.Items.Clear();
            foreach (string portname in SerialClass.GetSerialPropertyValue(SerialClass.SerialProperty.PortName))
            {
                cmbPortName.Items.Add(portname);
            }
        }

        /// <summary>
        /// 自动滚到最后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtReceived_TextChanged(object sender, EventArgs e)
        {
            txtReceived.SelectionStart = txtReceived.Text.Length; //Set the current caret position at the end
            txtReceived.ScrollToCaret(); //Now scroll it automatically
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                btnRefresh.Enabled = true;
                cmbBaudRate.Enabled = true;
                cmbDataBits.Enabled = true;
                cmbHandShaking.Enabled = true;
                cmbParity.Enabled = true;
                cmbPortName.Enabled = true;
                cmbStopBits.Enabled = true;
                btnOpen.BackColor = btnRefresh.BackColor;
                btnOpen.Text = "Open";
                SerialPort1.Close();
                SerialPort1.ComReceiveDataEvent -= SerialPort1_ComReceiveDataEvent;
                btnSendData.Enabled = false;
                tstlblConnectionSTAT.Text = "Not Connected";

            }
            else
            {
                btnRefresh.Enabled = false;
                cmbBaudRate.Enabled = false;
                cmbDataBits.Enabled = false;
                cmbHandShaking.Enabled = false;
                cmbParity.Enabled = false;
                cmbPortName.Enabled = false;
                cmbStopBits.Enabled = false;
                btnOpen.BackColor = Color.Red;
                btnOpen.Text = "Close";
                //SerialPort1.Open();
                SerialPort1.Open(cmbPortName.SelectedItem.ToString(),
                    cmbBaudRate.SelectedItem.ToString(),
                    cmbDataBits.SelectedItem.ToString(),
                    cmbStopBits.SelectedItem.ToString(),
                    cmbParity.SelectedItem.ToString(),
                    cmbHandShaking.SelectedItem.ToString());
                SerialPort1.ComReceiveDataEvent += SerialPort1_ComReceiveDataEvent;
                //取消，改到Form_Load
                //SerialPort1.ComOpenEvent += SerialPort1_ComComOpenEvent;
                //SerialPort1.ComCloseEvent += SerialPort1_ComComCloseEvent;
                btnSendData.Enabled = true;
                tstlblConnectionSTAT.Text = "Connected";
                
            }
        }

        private void TxtSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            //UsrControl.UsrControl.
            UsrControl.UsrControl.TxtHexCtrl(rdoHexSend.Checked,sender,e);
        }

        private void RdoHexSend_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHexSend.Checked)
            {
                txtSend.Text = UsrMethod.UsrConversion.String2Hex(txtSend.Text);
            }
            else
            {
                txtSend.Text = UsrMethod.UsrConversion.Hex2String(txtSend.Text);
            }
        }

        private void ChkSendRecycle_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSendRecycle.Checked)
            {
                int value1 = 0;
                 int.TryParse(txtSendRecycle.Text,out value1);
                tmrSendRecycle.Interval = value1;
                tmrSendRecycle.Enabled = true;
            }
            else
            {
                tmrSendRecycle.Enabled = false;
            }
        }

        private void TmrSendRecycle_Tick(object sender, EventArgs e)
        {
            BtnSendData_Click(sender,e);
        }

        private void RdoHexReceived_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHexReceived.Checked)
            {
                txtReceived.Text = UsrMethod.UsrConversion.String2Hex(txtReceived.Text);
            }
            else
            {
                txtReceived.Text = UsrMethod.UsrConversion.Hex2String(txtReceived.Text);
            }
        }
    }
}