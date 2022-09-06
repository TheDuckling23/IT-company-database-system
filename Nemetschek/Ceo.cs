using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemetschek
{
    public class Ceo : Worker
    {
        public int TaskManaged { get; set; }
        public Ceo(string name,string position, int years, int taskmanaged) : base(name, position , years)
        {
            TaskManaged = taskmanaged;
        }
        public override string ToString()
        {
            string fullresult = ($"{Position},{Name},{YearsOld},{TaskManaged}");
            return fullresult;
        }
    }
}
