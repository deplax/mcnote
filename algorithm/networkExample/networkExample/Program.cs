using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace networkExample
{
    class Program
    {
        static byte[] buf = new byte[1024];
        static void Main(string[] args)
        {

            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int port;
            Console.WriteLine("Port : ");
            port = int.Parse(Console.ReadLine());
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, port);
            s.Bind(ip);

            s.Listen(15);
            Console.WriteLine("서버 시작 - 주소 : {0} ", ip.ToString());
            while(true)
            {
                Socket client = s.Accept();
                Console.WriteLine("클라이언트 접속 : {0} ", client.RemoteEndPoint.ToString());
                NetworkStream ns = new NetworkStream(client);
                int len;
                while((len = ns.Read(buf, 0, buf.Length))!=0)
                {
                    string msg = Encoding.UTF8.GetString(buf, 0, len);
                    Console.WriteLine(msg);
                    byte[] send = Encoding.UTF8.GetBytes(msg + "\r\n뭐라고?");
                    ns.Write(send, 0, send.Length);
                }
                Console.WriteLine("다 읽었음 {0}", client.RemoteEndPoint.ToString());
                ns.Close();
                client.Close();
                

            }
        }
    }
}
