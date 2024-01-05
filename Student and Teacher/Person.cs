using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_Teacher
{
    abstract class Person
    {
        protected string[] names = new string[3];
        public abstract void Names();
    }
}
