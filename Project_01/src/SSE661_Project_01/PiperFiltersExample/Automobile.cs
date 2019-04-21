using System;
using System.Text;

namespace PiperFiltersExample
{
    public class Automobile
    {
        private string _vin;

        public StringBuilder Metadata { get; private set; }

        public Automobile(string vin)
        {
            _vin = vin;
            Metadata = new StringBuilder();
        }

        public void DisplayBuildMetadata()
        {
            Console.WriteLine(_vin);
            Console.WriteLine("===========");
            Console.WriteLine(Metadata.ToString());
        }
    }
}