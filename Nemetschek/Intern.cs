using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemetschek
{
    internal class Intern : Worker
    {
        public int YearInUni { get; set; }
        public Intern(string name, string position, int years, int yearinuni) : base(name, position, years)
        {
            YearInUni = yearinuni;
        }
        public override string ToString()
        {
            string fullresult = ($"{Position},{Name},{YearsOld},{YearInUni}");
            return fullresult;
        }
    }
}
