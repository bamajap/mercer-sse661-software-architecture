using System;
using ForwarderReceiver.Communications;
using ForwarderReceiver.Namespace;
using Mercer.SSE.LogFileTool;

namespace ForwarderReceiver.Army
{
    public class SoldierPeer
    {
        private const string PeerName = "Boots";

        static void Main(string[] args)
        {
            Log.Initialize();

            var forwarder = new Forwarder(PeerName);
            var receiver = new Receiver(PeerName);

            do
            {
                Console.Write("{0}> ", PeerName);
                var msg = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(msg))
                {
                    forwarder.SendMessage("Battleship", new Message(PeerName, "Exit"));
                    break;
                }

                var dataMsg = new Message(PeerName, msg);

                forwarder.SendMessage("Battleship", dataMsg);

                var response = receiver.ReceiveMessage();

                Console.WriteLine("{0}> [{1}]{2}", PeerName, response.Sender, response.Data);

                // Do something with response...

            } while (true);

            Log.Close();
        }
    }
}
