using lab_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ApplicationDbContext())
            {
                var student = new Student { Name = "Shady" };
                var course = new Course { Name = "Math" };
                db.Students.Add(student);
                db.Courses.Add(course);
                db.SaveChanges();

                var retrievedStudent = db.Students
                    .Include(s => s.Courses)
                    .First(s => s.Id == student.Id);

                if (retrievedStudent != null)
                {
                    retrievedStudent.Name = "Shady";
                    Console.WriteLine(retrievedStudent.Name);
                    db.Students.Remove(retrievedStudent);
                    db.SaveChanges();
                }
            }
        }
    }
}