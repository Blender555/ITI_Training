using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Student : Person
    {
        public Marks StudentMarks { get; set; }

        public Student(string name, int age, Marks marks) : base(name, age)
        {
            StudentMarks = marks;
        }

        public void DisplayStudentInfo()
        {
            DisplayInfo();
            StudentMarks.DisplayMarks();
            Console.WriteLine($"Total Marks: {StudentMarks.CalculateTotal()}");
        }
    }
}
