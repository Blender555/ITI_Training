using lab_1_linq;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n**************** Task 1 ****************\n");

        Person person1 = new Person { Name = "Shady", Age = 25 };
        Person person2 = new Person { Name = "Ahmed", Age = 50 };
        Person person3 = new Person { Name = "Shady", Age = 25 };

        person1.ComparePersons(person2);
        person1.ComparePersons(person3);
        person2.ComparePersons(person3);

        Console.WriteLine("\n**************** Task 2 ****************\n");

        List<Person> person_list = new List<Person>
        {
            new Person { Name = "Shady", Age = 25 },
            new Person { Name = "Ali", Age = 30 },
            new Person { Name = "Mohamed", Age = 35 }
        };

        foreach (var person in person_list)
        {
            Console.WriteLine($"{person.Name} (Age {person.Age}) - Hash Code: {person.GetHashCode()}");
        }

        Console.WriteLine("\n**************** Task 3 & 4 ****************\n");

        CustomCollection collection = new CustomCollection();

        foreach (var number in collection)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\n**************** Task 5 ****************\n");

        string str1 = "String";
        string str2 = "";
        string? str3 = null;

        Console.WriteLine($"Is str1 null or empty? {str1.IsNullOrEmpty()}");
        Console.WriteLine($"Is str2 null or empty? {str2.IsNullOrEmpty()}");
        Console.WriteLine($"Is str3 null or empty? {str3?.IsNullOrEmpty()}");

        Console.WriteLine("\n**************** Task 6 ****************\n");

        List<Person> persons = new List<Person>
        {
            new Person { Name = "Shady", Age = 25 },
            new Person { Name = "Ahmed", Age = 30 },
            new Person { Name = "Ali", Age = 35 },
            new Person { Name = "Mohamed", Age = 20 }
        };

        var names = persons.Select(p => p.Name);
        Console.WriteLine("Names:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        var olderThan20 = persons.Where(p => p.Age > 20);
        Console.WriteLine("\nPersons older than 20:");
        foreach (var person in olderThan20)
        {
            Console.WriteLine($"{person.Name} (Age {person.Age})");
        }

        var ofTypePerson = persons.OfType<Person>();
        Console.WriteLine("\nOf type Person:");
        foreach (var person in ofTypePerson)
        {
            Console.WriteLine($"{person.Name} (Age {person.Age})");
        }

        var orderedByName = persons.OrderBy(p => p.Name);
        Console.WriteLine("\nOrdered by Name:");
        foreach (var person in orderedByName)
        {
            Console.WriteLine($"{person.Name} (Age {person.Age})");
        }

        var orderedByNameDescending = persons.OrderByDescending(p => p.Name);
        Console.WriteLine("\nOrdered by Name Descending:");
        foreach (var person in orderedByNameDescending)
        {
            Console.WriteLine($"{person.Name} (Age {person.Age})");
        }

        var thenByAge = persons.OrderBy(p => p.Name).ThenBy(p => p.Age);
        Console.WriteLine("\nOrdered by Name then by Age:");
        foreach (var person in thenByAge)
        {
            Console.WriteLine($"{person.Name} (Age {person.Age})");
        }

        var thenByAgeDescending = persons.OrderBy(p => p.Name).ThenByDescending(p => p.Age);
        Console.WriteLine("\nOrdered by Name then by Age Descending:");
        foreach (var person in thenByAgeDescending)
        {
            Console.WriteLine($"{person.Name} (Age {person.Age})");
        }

        var reversed = persons.AsEnumerable().Reverse();
        Console.WriteLine("\nReversed List:");
        foreach (var person in reversed)
        {
            Console.WriteLine($"{person.Name} (Age {person.Age})");
        }
    }
}
