using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace TcpandPort
{
    public class ModbusPortdata
    {
        private string _portID;
        private int _baudID;
        SerialPort serialPort = null;
        public ModbusPortdata(string portid,int baudid)
        {
           this._portID = portid;
            this._baudID = baudid;
            serialPort = new SerialPort(portid,baudid,Parity.None,8,StopBits.One);
        }
        public bool OpenConnection()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                   return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"打开串口连接时出错: {ex.Message}");
                return false;
            }
        }
        public bool DisConnection()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
               return true ;
            }
            return false;
        }
        public void SendData(byte[] data)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(data, 0, data.Length);
            }
        }

        public byte[] ReceiveData(int bufferSize)
        {
            if (serialPort.IsOpen)
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead = serialPort.Read(buffer, 0, bufferSize);
                byte[] receivedData = new byte[bytesRead];
                Array.Copy(buffer, receivedData, bytesRead);
                return receivedData;
            }
            return null;
        }
    }

}

