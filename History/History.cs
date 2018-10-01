using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace History
{

    public delegate void EventTransactionHandler(int history);


    public class Event
    {

        public static void EventTransaction(int c) {

            Console.WriteLine("EventTransaction called {0}.", c);

        }


    }
}
