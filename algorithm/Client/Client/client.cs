using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace Client
{
    public class client
    {

        Socket s;
        public NetworkStream ns;
        byte[] buf = new byte[1024];
        public string Send(string input)
        {
            byte[] data = Encoding.UTF8.GetBytes(input);
            ns.Write(data, 0, data.Length);
            int len = ns.Read(buf, 0, buf.Length);
            string ret = Encoding.UTF8.GetString(buf, 0, len);
            return ret;
        }
        public string Connect(String address, int port)
        {
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ip = new IPEndPoint( IPAddress.Parse(address), port);
            try
            {
                s.Connect(ip);
            }catch (Exception e)
            {
                return e.Message;
            }
            ns = new NetworkStream(s);
            return "success";
        }

        public void Disconnect()
        {
            ns.Close();
            s.Close();
        }
    }
}
