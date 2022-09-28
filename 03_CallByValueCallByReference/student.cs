using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CallByValueCallByReference
{
    internal class Student
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
