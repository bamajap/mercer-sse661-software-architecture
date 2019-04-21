using System;
using System.Threading.Tasks;
using SSE661.Project4.Library.Interfaces;

namespace SSE661.Project4.ActiveObject
{
    /// <summary>
    /// Implementation of the active object.
    /// </summary>
    public class BidItem : IActiveObject
    {
        public int ProductId { get; private set; }

        public double Price { get; private set; }

        public string WinningBidder { get; private set; }

        private BidItem()
        {
            Price = 0;
            WinningBidder = string.Empty;
        }

        public BidItem(int id) : this()
        {
            ProductId = id;
        }

        public void SetBidPrice(string bidder, double bid)
        {
            Console.WriteLine("{0} is attempting to set bid price to ${1}.", bidder, bid);

            if (bid > Price)
            {
                Console.WriteLine("{0} is the high bidder!", bidder);
                Price = bid;
                WinningBidder = bidder;
                return;
            }

            Console.WriteLine("Bid of ${0} has been rejected because it is lower than " +
                              "the highest bid.", bid);
        }

        public Task<string> GetStatus(string bidder)
        {
            Func<string> result =
                () =>
                {
                    Console.WriteLine("Retrieving status for {0}...please wait", bidder);
                    return (bidder.Equals(WinningBidder))
                               ? string.Format("{0} is the highest bidder!", bidder)
                               : string.Format("{0} has been outbid.", bidder);
                };
            return new Task<string>(result);
        }
    }
}