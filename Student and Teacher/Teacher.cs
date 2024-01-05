using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_Teacher
{
    class Teacher : Person
    {
        public override void Names()
        {
            Console.Write("Enter teacher name: ");
            names[names.Length - 1] = Console.ReadLine();
            Console.WriteLine();
            Explain();
        }
        private void Explain()
        {
            Console.WriteLine($"{names[names.Length - 1] } is explaining");
        }
    }
}
