using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class MainClass
{
    public static void Main()
    {
        IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8001);

        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        try
        {
            server.Connect(ip);
        }
        catch (SocketException e)
        {
            Console.WriteLine("Unable to connect to server.");
            return;
        }

        
        

        server.Shutdown(SocketShutdown.Both);
        server.Close();
    }
}