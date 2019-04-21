using System;
using ForwarderReceiver.Communications;
using ForwarderReceiver.Namespace;
using Mercer.SSE.LogFileTool;

namespace ForwarderReceiver.Navy
{
    public class ShipPeer
    {
        private const string PeerName = "Battleship";

        static void Main(string[] args)
        {
            Log.Initialize();

            var forwarder = new Forwarder(PeerName);
            var receiver = new Receiver(PeerName);

            Console.WriteLine("Battleship is online and ready to serve!");

            while (true)
            {
                var message = receiver.ReceiveMessage();

                if (message.Data.Equals("Exit")) break;

                Console.WriteLine("{0}> [{1}]{2}", PeerName, message.Sender, message.Data);

                // Do something for client...

                var dataMsg = new Message(PeerName,
                                          string.Format("{0} has responded!", PeerName));

                forwarder.SendMessage(message.Sender, dataMsg);
            }

            Log.Close();
        }
    }
}