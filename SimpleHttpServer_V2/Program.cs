using System;
using System.Net;
using System.Net.Sockets;

namespace SimpleHttpServer // STATELESS!!
{
    // Main method to start the server and listen for incoming connections
    class Program
    {
        static void Main(string[] args)
        {
            // Create a TCP listener on localhost and port 8080
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Start();
            Console.WriteLine("Listening...");

            // Instantiate the request handler

            HttpRequestHandler requestHandler = new HttpRequestHandler();

            while (true)
            {
                
                HttpServer.HandleIncomingRequest(listener, requestHandler);
            }
        }
    }
}

