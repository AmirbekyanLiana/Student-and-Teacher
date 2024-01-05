using System;

namespace Student_and_Teacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Student student = new Student();
            student.Names();
            Teacher teacher = new Teacher();
            teacher.Names();
            student.Study();
        }
    }
}
