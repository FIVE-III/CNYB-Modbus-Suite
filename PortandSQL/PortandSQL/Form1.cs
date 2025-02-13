using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus.Device;
using Modbus.Message;
using TcpandPort;
namespace PortandSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelPort.Hide();
            panelTCP.Hide();
        }
       
        private void comBoxTCPandPort_DropDownClosed(object sender, EventArgs e)
        {
            if (comBoxTCPandPort.SelectedIndex == 0)
            {
                panelPort.Show();
                panelTCP.Hide();
                setBoxtext();
                setBauddata();
            }
            else
            {
                panelPort.Hide();
                panelTCP.Show();
                comBoxBaud.Items.Clear();
                comBoxCOMport.Items.Clear();
            }
        }
        #region//tcp的连接读取和写入
        private ModbusTCPdata modbusTCP = null;
        private void btnconnect_Click(object sender, EventArgs e)
        {
            //tcp连接
            modbusTCP = new ModbusTCPdata(txtTCPIP.Text.Trim(), int.Parse(txtTCPport.Text.Trim()));

            if (modbusTCP.Connect())
            {
                labelcannect.Text = "✔已连接";
            }
            else
            {
                labelcannect.Text = "✘已断开";
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            upDatatcp();
        }
        
        private void upDatatcp()
        {
            try
            {
                this.listBoxData.Items.Clear();
                ushort[] res = modbusTCP.ReadHoidingRegisters(0, Convert.ToUInt16(txtlength.Text));
                if (res != null)
                {
                    foreach (ushort value in res)
                    {
                        // 将数组元素逐行添加到 ListBox 中
                        this.listBoxData.Items.Add(value.ToString());
                    }
                    // this.listBoxData.Items.Insert(0, string.Join("\r\n", res));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnDis_tcp_Click(object sender, EventArgs e)
        {
            ///有bug，关闭后报错
            if (modbusTCP != null)
            {
                modbusTCP.Disconnect();
                labelcannect.Text = "✘已断开";
            }
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txttcpset.Text))
                {
                    modbusTCP.WriteSingleRegister_06(Convert.ToUInt16(listBoxData.SelectedIndex), Convert.ToUInt16(txttcpset.Text.Trim()));
                    upDatatcp();
                }
                else
                {
                    MessageBox.Show("写入数值不可为空！");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"写入错误: {ex.Message}");

            }
        }
        #endregion





     
        private void setBoxtext()
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= 256; i++)
            {
                list.Add("COM" + i.ToString());

            }
            comBoxCOMport.Items.AddRange(list.ToArray());
        }
        private void setBauddata()
        {
            List<string> buadList = new List<string>();
            for(int i = 300;i <= 614400;i*=2)
            {
                buadList.Add(i.ToString()+" Baud");
            }
            comBoxBaud.Items.AddRange(buadList.ToArray());
        }

    }
}
