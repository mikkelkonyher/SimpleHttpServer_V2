using System.IO;

namespace SimpleHttpServer
{
    class HttpResponse
    {
        public static void SendResponse(StreamWriter writer, string responseBody)
        {
            writer.WriteLine("HTTP/1.1 200 OK");
            writer.WriteLine("Content-Type: text/html; charset=UTF-8");
            writer.WriteLine("Connection: close");
            writer.WriteLine();
            writer.WriteLine(responseBody);
            writer.Flush();
        }
    }
}

