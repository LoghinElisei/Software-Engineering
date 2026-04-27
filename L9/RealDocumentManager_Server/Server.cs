using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RealDocumentManager_Server
{
    class Server
    {
        static void Main(string[] args)
        {
            TcpListener listener = null;
            try
            {
                int port = 8888;
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
                listener.Start();
                Console.WriteLine($"Serverul a pornit si ascultă pe portul {port}...");

                while (true)
                {
                    using (TcpClient client = listener.AcceptTcpClient())
                    using (NetworkStream stream = client.GetStream())
                    using (StreamReader reader = new StreamReader(stream))
                    using (StreamWriter writer = new StreamWriter(stream) { AutoFlush = true })
                    {
                        string request = reader.ReadLine();
                        if (!string.IsNullOrEmpty(request))
                        {
                            Console.WriteLine($"Cerere primită: {request}");
                            string[] parts = request.Split('|');
                            string command = parts[0];

                            if (command == "LIST")
                            {
                                int level = int.Parse(parts[1]);
                                RealDocumentManager rdm = new RealDocumentManager(level);
                                writer.WriteLine(string.Join(",", rdm.GetDocumentList()));
                            }
                            else if (command == "GET")
                            {
                                string docName = parts[1];
                                int level = int.Parse(parts[2]);
                                RealDocumentManager rdm = new RealDocumentManager(level);
                                writer.WriteLine(rdm.GetDocument(docName));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare Server: " + ex.Message);
            }
            finally
            {
                listener?.Stop();
            }
        }
    }
}
