using System.Threading.Tasks;
using SSE661.Project4.Library.Interfaces;

namespace SSE661.Project4.ActiveObject
{
    /// <summary>
    /// Method request class for the IActiveObject.SetBidPrice(...) method.
    /// </summary>
    public class SetBidPrice : MethodRequest
    {
        // Method request parameters
        private readonly string _bidder;
        private readonly double _bid;

        public SetBidPrice(IActiveObject bidItem, string bidder, double bid) : base(bidItem)
        {
            _bidder = bidder;
            _bid = bid;
        }

        /// <summary>
        /// Called from the dispatch thread to execute the IActiveObject.SetBidPrice(...)
        /// method.
        /// </summary>
        public override void Execute()
        {
            _bidItem.SetBidPrice(_bidder, _bid);
        }
    }

    /// <summary>
    /// Method request class for the IActiveObject.GetStatus(...) method.
    /// </summary>
    public class GetStatus : MethodRequest<string>
    {
        // Method request parameter
        private readonly string _bidder;

        public GetStatus(IActiveObject bidItem, string bidder, out Task<string> future)
            : base(bidItem)
        {
            _bidder = bidder;
            _future = _bidItem.GetStatus(_bidder);
            future = _future;
        }

        /// <summary>
        /// Called from the dispatch thread to execute the IActiveObject.GetStatus(...)
        /// method.
        /// </summary>
        public override void Execute()
        {
            _future.Start();
        }
    }
}