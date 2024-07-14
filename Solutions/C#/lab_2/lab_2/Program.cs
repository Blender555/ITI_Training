using System;
using System.Net;
using System.Xml.Linq;
namespace lab_2
{
    class Program
     {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Test";
            person.Age = 10;
            person.Address = "Test";
            person.DisplayPersonDetails();
        }
     }
}