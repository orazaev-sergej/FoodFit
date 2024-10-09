using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace FoodFit.Classes
{
    public void StartUdpServer()
    {
        int port = 12345;
        UdpClient udpServer = new UdpClient(port);

        Console.WriteLine("UDP Server running...");
        IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, port);
        byte[] receivedBytes = udpServer.Receive(ref remoteEndPoint);
        string receivedData = Encoding.ASCII.GetString(receivedBytes);
        Console.WriteLine("Received: " + receivedData);

        udpServer.Close();
    }
}