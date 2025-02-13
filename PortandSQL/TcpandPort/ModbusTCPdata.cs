using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TcpandPort
{
    public class ModbusTCPdata
    {
        private string tcp_modbusIP;
        private int tcp_modbusPort;
        public byte SlaveId{ get; set; } = 0x01;
        private Socket tcpClient = null;

        public ModbusTCPdata(string ip, int port)
        {
            this.tcp_modbusIP = ip;
            this.tcp_modbusPort = port;
        }


        /// <summary>
        /// 连接
        /// </summary>
        /// <returns>是否连接成功</returns>
        public bool Connect()
        {
            tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                tcpClient.Connect(System.Net.IPAddress.Parse(tcp_modbusIP), tcp_modbusPort);
            }
            catch 
            {
                return false;
                
            }
            return true;
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        public void Disconnect()
        {
            if (tcpClient != null)
            {
                tcpClient.Close();
            }
        }
        /// <summary>
        /// 读取保持型寄存器数据
        /// </summary>
        /// <param name="start">起始</param>
        /// <param name="length">长度</param>
        /// <returns></returns>
        public ushort[] ReadHoidingRegisters(ushort start, ushort length)
        {
            List<byte>SendConmmand= new List<byte>();
            //1，拼接报文
            SendConmmand.AddRange(new byte[] { 0, 0, 0, 0 });
            SendConmmand.AddRange(new byte[] { 0, 6 });
                       //添加从站地址
            SendConmmand.Add(SlaveId);
                      //添加功能码
            SendConmmand.Add(0x03);
                         //取高位
            SendConmmand.Add((byte)(start / 256));
                        //取低位
            SendConmmand.Add(((byte)(start % 256)));

            SendConmmand.Add((byte)(length / 256));
            SendConmmand.Add((byte)(length % 256));


            //2，发送报文
            tcpClient.Send(SendConmmand.ToArray());

            //3，接收报文
            byte[] buffer = new byte[512];
            
            //字节数
            int count = tcpClient.Receive(buffer);
            byte[] des = new byte[count];
            //4，验证报文

            {
                    //截取
                    des = new byte[count];
                    Array.Copy(buffer, 0, des, 0, count);

                    //二次验证
                    if (des[6] == SlaveId && des[7] == 0x03 && des[8] == 2 * length)
                    {
                        //5，解析报文
                        byte[] res = new byte[2 * length];
                        Array.Copy(des, 9, res, 0, 2 * length);

                        List<ushort> result = new List<ushort>();

                        for (int i = 0; i < res.Length; i+=2)
                        {
                            result.Add(Convert.ToUInt16(res[i] * 256 + res[i + 1]));
                        }
                        return result.ToArray();
                    }
                }
            return null;
        }


        /// <summary>
        /// 写入单个寄存器06
        /// </summary>
        /// <param name="registerAddress">寄存器</param>
        /// <param name="value">要写入的值</param>
        /// <returns></returns>
        public bool WriteSingleRegister_06(ushort registerAddress, ushort value)
        {
            
            List<byte> command=new List<byte>();

            command.AddRange(new byte[] { 0, 0, 0, 0 });
            command.AddRange(new byte[] { 0, 6 });

            command.Add(SlaveId);
            command.Add(0x06);
            // 寄存器地址
            command.Add((byte)(registerAddress / 256));
            command.Add((byte)(registerAddress % 256));
            // 要写入的值
            command.Add((byte)(value / 256));
            command.Add((byte)(value % 256));
            try
            {
                // 发送报文
                tcpClient.Send(command.ToArray());
                // 接收响应
                byte[] buffer = new byte[512];
                int count = tcpClient.Receive(buffer);
                // 简单验证响应
                if (count == 12 && buffer[6] == SlaveId && buffer[7] == 0x06)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"写入单个寄存器发生错误: {ex.Message}");
            }
            return false;
        }
    }
}
