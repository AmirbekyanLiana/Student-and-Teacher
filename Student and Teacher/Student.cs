using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_Teacher
{
    class Student : Person
    {
        public override void Names()
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                Console.Write("Enter student name: ");
                names[i] = Console.ReadLine();
            }            
        }
        public void Study()
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                Console.WriteLine($"{names[i]} is studying");
            }
        }
    }
}
