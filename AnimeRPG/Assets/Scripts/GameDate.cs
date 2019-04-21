using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamana
{
    [Serializable]
    public struct GameDate
    {
        public int year;
        public int month;
        public int day;

        public GameDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
    }
}
