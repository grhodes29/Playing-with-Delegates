using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker;


namespace Playing_with_Delegates
{

    public enum WorkType {


        Lazy,
        Hard

    }


   // public event WorkPerformedHandler WorkPerformed;

    class Program
    {


        static void Main(string[] args)
        {


            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformedA);

            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformedB);

            del1 += del2;

            del1(2, WorkType.Hard);


           // SettingUpDeletegates();
            History h = new History(HistoryType.Type1);
            EventTransactionHandler _handler = new EventTransactionHandler(EventTransaction.Transaction);
            _handler(h);


            Console.ReadLine();

        }


        



        static void WorkPerformedA(int parmHour, WorkType parmWorkType)
        {

            Console.WriteLine("WorkPerformedA called." + parmWorkType);

        }


        static void WorkPerformedB(int parmHour, WorkType parmWorkType)
        {

            Console.WriteLine("WorkPerformedB called.");

        }
    }
}
