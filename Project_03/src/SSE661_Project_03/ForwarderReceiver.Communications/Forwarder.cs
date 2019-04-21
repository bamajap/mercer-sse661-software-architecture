using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ForwarderReceiver.Namespace;

namespace ForwarderReceiver.Communications
{
    public class Forwarder
    {
        private string PeerName { get; set; }

        public Forwarder(string peerName)
        {
            PeerName = peerName;
        }

        public void SendMessage(string destination, Message msg)
        {
            try
            {
                var id = Map.Clients[destination].Split(':');
                var ip = id[0];
                var port = Int32.Parse(id[1]);

                var data = Marshal(msg);

                // Create a TcpClient. 
                // Note, for this client to work a TcpServer must be connected to the same
                // address as specified by the server's IP and port number combination.
                var client = new TcpClient();
                client.Connect(ip, port);

                // Get a client stream for reading and writing.
                var stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

                // Close everything.
                stream.Dispose();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }

        private byte[] Marshal(Message msg)
        {
            // Translate the passed message into ASCII and store it as a Byte array.
            var data = Encoding.ASCII.GetBytes(string.Format("[{0}]{1}",
                                                             msg.Sender, msg.Data));
            var numBytes = 4 + data.Length;

            var packet = new byte[numBytes];

            Buffer.BlockCopy(BitConverter.GetBytes(numBytes), 0, packet, 0, 4);
            Buffer.BlockCopy(data, 0, packet, 4, data.Length);

            return packet;
        }
    }

    public class Receiver
    {
        public string PeerName { get; private set; }

        public Receiver(string peerName)
        {
            PeerName = peerName;
        }

        private Message Unmarshal(byte[] buffer)
        {
            var msgSize = BitConverter.ToInt32(buffer, 0) - 4;

            var msg = Encoding.ASCII.GetString(buffer, 4, msgSize);
            var sender = msg.Substring(1, msg.IndexOf(']') - 1);
            var senderLength = sender.Length + 2;
            var data = msg.Substring(senderLength, msg.Length - senderLength);

            return new Message(sender, data);
        }

        private byte[] Receive()
        {
            byte[] bytes = null;
            TcpListener server = null;

            try
            {
                var id = Map.Clients[PeerName].Split(':');
                var ip = id[0];
                var port = Int32.Parse(id[1]);

                // Set the TcpListener on the port specified in the namespace map.
                var localAddr = IPAddress.Parse(ip);

                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                String data = null;

                Console.WriteLine("{0} : ", PeerName);

                // Perform a blocking call to accept requests. 
                TcpClient client = server.AcceptTcpClient();
                //Console.WriteLine("Connected!");

                // Get a stream object for reading and writing
                NetworkStream stream = client.GetStream();

                // Read in the first 256 bytes of the network stream.
                bytes = new byte[256];
                stream.Read(bytes, 0, bytes.Length);

                // Shutdown and end connection
                client.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                if (server != null) server.Stop();
            }
            return bytes;
        }

        public Message ReceiveMessage()
        {
            return Unmarshal(Receive());
        }
    }
}