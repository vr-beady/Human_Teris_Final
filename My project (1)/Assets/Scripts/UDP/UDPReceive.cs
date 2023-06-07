using UnityEngine;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class UDPReceive : MonoBehaviour
{
    private GameManager gM;
    
    Thread receiveThread;
    UdpClient client;
    private int port = 5054;
    public bool startRecieving = true;
    public bool printToConsole = false;
    public string data;

    public void Start()
    {
        client = new UdpClient(port); //初始化UdpClient
        receiveThread = new Thread(new ThreadStart(ReceiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();
    }
    // receive thread
    private void ReceiveData()
    {
        //client.Client.Bind(new IPEndPoint(IPAddress.Any, port)); //綁定連接埠
        //client = new UdpClient(port);
        while (startRecieving)
        {

            try
            {
                IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
                byte[] dataByte = client.Receive(ref anyIP);
                data = Encoding.UTF8.GetString(dataByte);

                if (printToConsole) { print(data); }
            }
            catch (Exception err)
            {
                print(err.ToString());
            }
        }
    }
    public void UDPClose()
    {
        receiveThread.Abort();
        client.Close();
    }
}
