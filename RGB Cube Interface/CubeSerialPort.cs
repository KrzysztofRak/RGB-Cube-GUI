using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace RGB_Cube_Interface
{
    class CubeSerialPort
    {
        private System.IO.Ports.SerialPort port;

        public CubeSerialPort()
        {
            port = new System.IO.Ports.SerialPort();
        }

        public bool SelectSerialPort(string name)
        {
            try
            {
                port.Close();
                port = new System.IO.Ports.SerialPort(name, 57600);
                port.Open();
                return false;
            }
            catch
            {
                return true;
            }
        }

        public void Disconnect()
        {
            try
            {
                port.Close();
            }
            catch
            {
            }
        }

        public string[] GetSerialPorts()
        {
            return System.IO.Ports.SerialPort.GetPortNames();
        }


        public void SendData(string data)
        {
            try
            {
                if (!port.IsOpen)
                    port.Open();

                port.Write(data);
            }
            catch { }
        }
    }
}
