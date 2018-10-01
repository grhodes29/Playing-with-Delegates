using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker
{

    public delegate void EventTransactionHandler(History history);

    public class EventTransaction
    {


        public event EventTransactionHandler WorkPerformed;
        public event EventHandler WorkCompleted;

        public static void Transaction(History history)
        {

            Console.WriteLine("EventTransaction called {0}.", history.HistoryType);

            
          
        }



        protected virtual void OnHistory(History h) {

            EventTransactionHandler _handler = WorkPerformed as EventTransactionHandler;

            if (_handler != null)  // listeners are attached
            {
                _handler(h); // raise event
            }
        }


    }
}
