using System;
using System.Net;
using Systen.Net.Socket;
using System.Text;

namespace FoodFit.Classes
{
    internal void SendDataUdp(string data)
    {
        string server = "192.168.1.1";
        int port = 8081;
        UdpClient udpClient = new UdpClient();
        IpEndPoint ep = new IpEndPoint(IPAdress.Parse(server), port);
        udpClient.Connect(ep);

        byte[] dataToSend = Encoding.UTF8.GetBytes(data);
        udpClient.Send(dataToSend, dataToSend.Length);

        udpClient.Close();
    }
}