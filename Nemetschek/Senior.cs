using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemetschek
{
    internal class Senior : Worker
    {
        public int ExpYears { get; set; }
        public Senior(string name, string position, int years, int expyears) : base(name, position, years)
        {
            ExpYears = expyears;
        }
        public override string ToString()
        {
            string fullresult = ($"{Position},{Name},{YearsOld},{ExpYears}");
            return fullresult;
        }
    }
}
