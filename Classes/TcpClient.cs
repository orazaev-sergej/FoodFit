using System;
using System.Net.Sockets;
using System.Text;

namespace FoodFit.Classes
{
    public void SendDataTcp(string data)
    {
        string server = "192.168.1.1";
        int port = 12345;
        try
        {
            using (TcpClient client = new TcpClient(server, port))
            using (NetworkStream stream = client.GetStream())
            {
                byte[] dataToSend = Encoding.ASCII.GetBytes(data);
                stream.Write(dataToSend, 0, dataToSend.Length);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error sending data: " + ex.Message);
        }
    }
}