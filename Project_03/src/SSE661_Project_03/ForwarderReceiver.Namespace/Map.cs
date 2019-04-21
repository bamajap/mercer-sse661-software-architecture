using System.Collections.Generic;

namespace ForwarderReceiver.Namespace
{
    public static class Map
    {
        public static Dictionary<string, string> Clients =
            new Dictionary<string, string>
            {
                {"Battleship", "192.168.137.107:8989"},
                {"Boots", "192.168.137.107:9090"},
            };
    }

    public class Message
    {
        public string Sender { get; private set; }

        public string Data { get; private set; }

        private Message() { }

        public Message(string sender, string data)
        {
            Sender = sender;
            Data = data;
        }
    }
}