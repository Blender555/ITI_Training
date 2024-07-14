namespace lab_3
{

    public class Person
    {
        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        #endregion

        #region Constructors
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public Person(Person p)
        {
            Name = p.Name;
            Age = p.Age;
            Address = p.Address;
        }
        #endregion

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Address: {Address}";
        }
    }

    public struct ValueTypeExample
    {
        public int Value { get; set; }
    }

    public class ReferenceTypeExample
    {
        public int Value { get; set; }
    }

    public class GCClass
    {
        public GCClass()
        {
            Console.WriteLine("GCClass object created.");
        }

        ~GCClass()
        {
            Console.WriteLine("GCClass object destroyed.");
        }
    }

    public class Animal
    {
        public string? Name { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} is moving.");
        }
    }

    public class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine($"{Name} is flying.");
        }
    }

    public sealed class Eagle : Bird { }

    public abstract class AbstractAnimal
    {
        public string? Name { get; set; }
        public abstract void MakeSound();
    }

    public class Dog : AbstractAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Woof!");
        }
    }



    class Program
    {
        public static void CreateObject()
        {
            GCClass gc = new GCClass();
        }
        static void Main(string[] args)
        {
            //Person person1 = new Person("shady", 21, "123 Street");
            //Person person2 = new Person(person1);
            //Console.WriteLine(person1);
            //Console.WriteLine(person2);

            //ValueTypeExample valueType1 = new ValueTypeExample { Value = 10 };
            //ValueTypeExample valueType2 = valueType1;
            //valueType2.Value = 20;
            //Console.WriteLine($"ValueType1: {valueType1.Value}, ValueType2: {valueType2.Value}");

            //ReferenceTypeExample referenceType1 = new ReferenceTypeExample { Value = 10 };
            //ReferenceTypeExample referenceType2 = referenceType1;
            //referenceType2.Value = 20;
            //Console.WriteLine($"ReferenceType1: {referenceType1.Value}, ReferenceType2: {referenceType2.Value}");

            //CreateObject();
            //GC.Collect();
            //Thread.Sleep(1000);

            //Animal animal = new Animal { Name = "Lion" };
            //Bird bird = new Bird { Name = "Parrot" };
            //animal.Move();
            //bird.Move();

            //Dog dog = new Dog { Name = "Rex" };
            //dog.MakeSound();
        }
    }
}