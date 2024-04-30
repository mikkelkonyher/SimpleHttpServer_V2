using System;
using System.IO;
using System.Net.Sockets;

namespace SimpleHttpServer
{
    class HttpServer
    {
        public static void HandleIncomingRequest(TcpListener listener, HttpRequestHandler requestHandler)
        {
            using (TcpClient client = listener.AcceptTcpClient())
            using (NetworkStream stream = client.GetStream())
            using (StreamReader reader = new StreamReader(stream))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                Console.WriteLine("Client connected.");

                string requestString = reader.ReadLine();
                Console.WriteLine("Request: " + requestString);

                string responseString = requestHandler.HandleRequest(requestString);
                Console.WriteLine("Response: " + responseString);

                HttpResponse.SendResponse(writer, responseString);
            }
        }
    }
}

