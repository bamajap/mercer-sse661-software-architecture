using System.Threading.Tasks;
using SSE661.Project4.Library.Interfaces;

namespace SSE661.Project4.ActiveObject
{
    /// <summary>
    /// Proxy for the active object class.  It inherits from the same interface as that
    /// of the actual active object.
    /// </summary>
    public class BidItemProxy : IActiveObject
    {
        /// <summary>
        /// Active object that the proxy is "wrapping".
        /// </summary>
        private IActiveObject BidItem { get; set; }

        /// <summary>
        /// Method request scheduler for the active object.
        /// </summary>
        private Scheduler Scheduler { get; set; }

        private BidItemProxy()
        {
            Scheduler = new Scheduler();
        }

        public BidItemProxy(int id) : this()
        {
            BidItem = new BidItem(id);
        }

        /// <summary>
        /// An action method of the active object that is provided by the proxy 
        /// </summary>
        public void SetBidPrice(string bidder, double bid)
        {
            Scheduler.Insert(new SetBidPrice(BidItem, bidder, bid));
        }

        /// <summary>
        /// A method of the proxy that returns a "future" result.  This result will be
        /// generated when the method is actually invoked on the active object by the
        /// dispatch thread.  This call is non-blocking.
        /// </summary>
        /// <param name="bidder">Name of the bidder requesting the status.</param>
        /// <returns>A non-blocking future value that will contain the active object's
        /// status.</returns>
        public Task<string> GetStatus(string bidder)
        {
            Task<string> future;
            var request = new GetStatus(BidItem, bidder, out future);
            Scheduler.Insert(request);
            return future;
        }
    }
}