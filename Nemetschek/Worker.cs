using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemetschek
{
    public class Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int YearsOld { get; set; }

        public Worker(string name, string position, int years)
        {
            Name = name;
            Position = position;
            YearsOld = years;
        }
    }
}
