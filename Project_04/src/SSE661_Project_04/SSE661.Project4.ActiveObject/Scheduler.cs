using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace SSE661.Project4.ActiveObject
{
    /// <summary>
    /// The method request scheduler that is responsible for tracking requested
    /// invokations of active object methods and executing the requests on the active
    /// object in a sepearate thread (dispatch thread).
    /// </summary>
    public class Scheduler
    {
        /// <summary>
        /// Asynchronous activation container that manages the method requests in the form
        /// of a queue.
        /// </summary>
        private BlockingCollection<MethodRequest> Queue { get; set; }

        public Scheduler()
        {
            // BlockingCollection accepts a parameter as a capacity which limits the size
            // of the Queue to protect against many service requests which would result in
            // a large Queue negatively affecting performance.  For this project, however,
            // a simplistic approach is used in which no capacity is set on the Queue.
            Queue = new BlockingCollection<MethodRequest>();

            // Create and start the background dispatch thread.  The dispatch thread
            // starts listening for method requests while the client thread returns to
            // its expected behavior.
            Task.Factory.StartNew(Dispatch);
        }

        /// <summary>
        /// Adds a method request to the activation queue.
        /// </summary>
        /// <param name="methodRequest">The method request to add.</param>
        public void Insert(MethodRequest methodRequest)
        {
            Queue.Add(methodRequest);
        }

        /// <summary>
        /// Listener loop started by the scheduler in a background thread that "listens"
        /// for the existence of method requests.
        /// </summary>
        public void Dispatch()
        {
            do
            {
                // Block the dispatch thread until a request is placed on the Queue.
                var request = Queue.Take();

                // DESIGN DECISION: No guard methods are in place since CanExecute always
                // returns true.

                // Execute the request
                request.Execute();
            } while (true);
        }
    }
}