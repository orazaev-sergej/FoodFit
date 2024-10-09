using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace FoodFit.Classes
{
    public void StartTcpServer()
    {
        int port = 12345;
        TcpListener server = new TcpListener(IPAddress.Any, port);
        server.Start();

        Console.WriteLine("TCP Server running...");
        TcpClient client = server.AcceptTcpClient();
        NetworkStream stream = client.GetStream();

        byte[] buffer = new byte[client.ReceiveBufferSize];
        int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
        string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
        Console.WriteLine("Received: " + dataReceived);

        stream.Close();
        client.Close();
        server.Stop();
    }
}