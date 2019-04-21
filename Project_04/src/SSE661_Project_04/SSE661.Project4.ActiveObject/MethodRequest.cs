using System.Threading.Tasks;
using SSE661.Project4.Library.Interfaces;

namespace SSE661.Project4.ActiveObject
{
    /// <summary>
    /// Base class that all active object method requests must inherit from.  Method
    /// requests that do not return a value (future) should inherit from this class
    /// specifically.
    /// </summary>
    public abstract class MethodRequest
    {
        protected IActiveObject _bidItem;

        protected MethodRequest()
        {
        }

        protected MethodRequest(IActiveObject bidItem)
        {
            _bidItem = bidItem;
        }

        /// <summary>
        /// Guard method to be utilized by the method request dispatcher.
        /// </summary>
        public virtual bool CanExecute
        {
            get { return true; }
        }

        /// <summary>
        /// This method is called by the dispatcher (from the active object's context
        /// thread) to perform the actual execution of the requested method made by the
        /// client.  Inheriting method request classes will override this with the call to
        /// the active object's method that it represents.
        /// </summary>
        public abstract void Execute();
    }

    /// <summary>
    /// Generic base class that all value-returning method request classes should inherit
    /// from.
    /// </summary>
    /// <typeparam name="T">The type of value (future) that should be returned by this
    /// method request.</typeparam>
    public abstract class MethodRequest<T> : MethodRequest
    {
        /// <summary>
        /// The future to be returned by the method request.
        /// </summary>
        protected Task<T> _future;

        protected MethodRequest(IActiveObject bidItem) : base(bidItem)
        {
        }
    }
}