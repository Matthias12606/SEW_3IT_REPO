using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NullabelDatatypes
{
    internal class student
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
