using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_with_Delegates
{
    public class Worker
    {

        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;


        public void DoWork(int hours, WorkType workType) {

            for (int i = 0; i < hours; i++)
            {

            }


        }




        protected virtual void OnWorkPerformed(int hours, WorkType workType) {


            var del = WorkPerformed as WorkPerformedHandler;
        }


    }
}
