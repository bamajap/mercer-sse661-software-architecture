using System.Threading.Tasks;

namespace SSE661.Project4.Library.Interfaces
{
    /// <summary>
    /// Interface of the active object.
    /// </summary>
    public interface IActiveObject
    {
        void SetBidPrice(string bidder, double bid);
        
        Task<string> GetStatus(string bidder);
    }
}
