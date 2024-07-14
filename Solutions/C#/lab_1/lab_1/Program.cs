using System;

namespace lab_1
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y}, {Z})");
        }

        public static double CalculateDistance(Point3D p1, Point3D p2)
        {
            return Math.Abs(p1.X - p2.X);
        }
    }
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }

        public static Fraction Add(Fraction f1, Fraction f2)
        {
            int newNumerator = (f1.Numerator * f2.Denominator) + (f2.Numerator * f1.Denominator);
            int newDenominator = f1.Denominator * f2.Denominator;
            return new Fraction { Numerator = newNumerator, Denominator = newDenominator };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Point3D p1 = new Point3D();
            //Point3D p2 = new Point3D();
            //Point3D p3 = new Point3D();
            //p1.X = 1; p1.Y = 1; p1.Z = 1;
            //p2.X = 2; p2.Y = 2; p2.Z = 2;
            //p1.Display();
            //p2.Display();
            //Console.WriteLine($"Distance: {Point3D.CalculateDistance(p1, p2)}");

            /*******************************/

            //Fraction f1 = new Fraction();
            //Fraction f2 = new Fraction();
            //f1.Numerator = 2;
            //f1.Denominator = 5;
            //f2.Numerator = 3;
            //f2.Denominator = 5;
            //f1.Display();
            //f2.Display();
            //Fraction f3 = Fraction.Add(f1, f2);
            //f3.Display();
        }
    }
}