using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker
{

    public enum HistoryType {

        Type1,
        Type2,
        Type3

    }




    public class History
    {
        private HistoryType type1;

        public History(HistoryType type1)
        {
            this.type1 = type1;
        }

        public HistoryType HistoryType { get; set; }



    }
}
