using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Marks
    {
        public int Math { get; set; }
        public int Science { get; set; }
        public int English { get; set; }

        public Marks(int math, int science, int english)
        {
            Math = math;
            Science = science;
            English = english;
        }

        public int CalculateTotal()
        {
            return Math + Science + English;
        }

        public void DisplayMarks()
        {
            Console.WriteLine($"Math: {Math}, Science: {Science}, English: {English}");
        }
    }
}
