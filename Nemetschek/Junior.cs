using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemetschek
{
    internal class Junior : Worker
    {
        public int TaskNum { get; set; }
        public Junior(string name, string position, int years, int tasknum) : base(name, position, years)
        {
            TaskNum = tasknum;
        }
        public override string ToString()
        {
            string fullresult = ($"{Position},{Name},{YearsOld},{TaskNum}");
            return fullresult;
        }
    }
}
