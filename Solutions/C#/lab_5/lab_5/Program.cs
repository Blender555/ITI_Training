using System;
using System.Collections;
using System.IO;
namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n********* Task 1&2 *********\n");

            Animal myDog = new Dog();
            Animal myCat = new Cat();
            myDog.MakeSound();
            myCat.MakeSound();

            List<IMovable> animals = new List<IMovable>
            {
            new Dog(),
            new Cat()
            };
            foreach (var animal in animals)
            {
                animal.Move();
            }

            Console.WriteLine("\n********* Task 3&4 *********\n");

            string filePath = @"D:\Study\ITI_Training\Labs\Solutions\C#\lab_5\Animals.txt";
            string newFilePath = @"D:\Study\ITI_Training\Labs\Solutions\C#\lab_5\newAnimals.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                using (StreamWriter writer = new StreamWriter(newFilePath))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }

            Console.WriteLine("\n********* Task 5 *********\n");

            ArrayList chars = new ArrayList { "A", "B", "C" };
            List<int> nums = new List<int> { 1, 2, 3 };

            chars.Add("D");
            nums.Add(4);
            chars.AddRange(new string[] { "E", "F" });
            nums.AddRange(new int[] { 5, 6 });

            chars.Insert(1, "G");
            nums.Insert(2, 7);

            chars.Remove("B");
            nums.Remove(3);
            chars.RemoveAt(0);
            nums.RemoveAt(1);

            int indexInArrayList = chars.IndexOf("F");
            int indexInIntList = nums.IndexOf(4);
            Console.WriteLine($"Index of 'F' in ArrayList: {indexInArrayList}");
            Console.WriteLine($"Index of 4 in List: {indexInIntList}");

            Console.WriteLine("\n***********************\n");

            bool containsInchars = chars.Contains("C");
            bool containsInnums = nums.Contains(2);
            Console.WriteLine($"ArrayList contains 'C': {containsInchars}");
            Console.WriteLine($"List contains 2: {containsInnums}");

            Console.WriteLine("\n***********************\n");

            nums.Sort();
            Console.WriteLine("Sorted List:");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\n***********************\n");

            chars.Clear();
            nums.Clear();

            Console.WriteLine($"ArrayList count after clear: {chars.Count}");
            Console.WriteLine($"List count after clear: {nums.Count}");
        }
    }
}