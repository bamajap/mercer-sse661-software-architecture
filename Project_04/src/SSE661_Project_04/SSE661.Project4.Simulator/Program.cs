using System;
using System.Threading.Tasks;
using Mercer.SSE.LogFileTool;
using SSE661.Project4.ActiveObject;

namespace SSE661.Project4.Simulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Log.Initialize();
            Run();
            Console.ReadKey();
            Log.Close();
        }

        private static void Run()
        {
            var bidItemProxy = new BidItemProxy(123);

            var blueBidder = new Bidder("Blue");
            var redBidder = new Bidder("Red");

            Action blueBidAction = () =>
                                   {
                                       // Blue bidder places a bid and retrieves the status.
                                       var blue = blueBidder.Name;
                                       bidItemProxy.SetBidPrice(blue, 1);
                                       var blueResult = bidItemProxy.GetStatus(blue);
                                       Console.WriteLine(blueResult.Result);
                                   };

            Action redBidAction = () =>
                                  {
                                      // Red bidder places a bid and retrieves the status.
                                      var red = redBidder.Name;
                                      bidItemProxy.SetBidPrice(red, 2);
                                      var redResult = bidItemProxy.GetStatus(red);
                                      Console.WriteLine(redResult.Result);
                                  };

            // Simulate two bidders bidding on the same bid item (active object).
            Parallel.Invoke(blueBidAction, redBidAction);
        }

        internal class Bidder
        {
            public string Name { get; private set; }

            private Bidder()
            {
            }

            public Bidder(string name)
            {
                Name = name;
            }
        }
    }
}