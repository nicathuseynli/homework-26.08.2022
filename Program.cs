using System;

namespace _26._08._2022_homework
{
    internal class Program
    {


    //        static void Main(string[] args);

#region Task1
//        public class FirstInterface
//        {
//            public static void Main(string[] args)
//            {
//                Car car = new Car(0);

//                int fuel = int.Parse(Console.ReadLine());
//                if (car.Refuel(fuel))
//                {
//                    car.Drive();
//                }
//            }

//            public interface IVehicle
//            {
//                void Drive();
//                bool Refuel(int amount);
//            }

//            public class Car : IVehicle
//            {
//                public int Fuel { get; set; }

//                public Car(int fuel)
//                {
//                    Fuel = fuel;
//                }

//                public void Drive()
//                {
//                    if (Fuel > 0)
//                    {
//                        Console.WriteLine("Driving");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Not fuel");
//                    }
//                }

//                public bool Refuel(int amount)
//                {
//                    Fuel += amount;
//                    return true;
//                }
//            }

//        }

//    }
#endregion
#region Task 2

//    public static void Main(string[] args)
//    {
//        int total = 3;
//        Person[] persons = new Person[total];

//        for (int i = 0; i < total; i++)
//        {
//            persons[i] = new Person()
//            {
//                Name = Console.ReadLine()
//            };
//        }

//        for (int i = 0; i < total; i++)
//        {
//            Console.WriteLine(persons[i].ToString());
//        }

//        Console.ReadLine();
//    }

//    public class Person
//    {
//        public string Name { get; set; }

//        public override string ToString()
//        {
//            return "Hello! My name is " + Name;
//        }
//    }
#endregion
#region Task3

//    public static void Main(string[] args)
//    {
//        Dog dog = new Dog();
//        dog.SetName(Console.ReadLine());
//        Console.WriteLine(dog.GetName());
//        dog.Eat();
//    }

//    public class Dog : Animal
//    {
//        public override void Eat()
//        {
//            Console.WriteLine("Eating");
//        }
//    }

//    public abstract class Animal
//    {
//        private string Name;

//        public void SetName(string name)
//        {
//            Name = name;
//        }

//        public string GetName()
//        {
//            return Name;
//        }

//        public abstract void Eat();
//    }
#endregion
#region Task4
//    public static void Main(string[] args)
//    {
//        int total = 3;
//        Person[] persons = new Person[total];

//        for (int i = 0; i < total; i++)
//        {
//            if (i == 0)
//            {
//                persons[i] = new Teacher(Console.ReadLine());
//            }
//            else
//            {
//                persons[i] = new Student(Console.ReadLine());
//            }
//        }

//        for (int i = 0; i < total; i++)
//        {
//            if (i == 0)
//            {
//                ((Teacher)persons[i]).Explain();

//            }
//            else
//            {
//                ((Student)persons[i]).Study();
//            }
//        }
//    }

//    public class Person
//    {
//        protected string Name { get; set; }

//        public Person(string name)
//        {
//            Name = name;
//        }

//        public override string ToString()
//        {
//            return "Hello! My name is " + Name;
//        }

//        ~Person()
//        {
//            Name = string.Empty;
//        }
//    }

//    public class Teacher : Person
//    {
//        public Teacher(string name) : base(name)
//        {
//            Name = name;
//        }

//        public void Explain()
//        {
//            Console.WriteLine("Explain");
//        }
//    }

//    public class Student : Person
//    {
//        public Student(string name) : base(name)
//        {
//            Name = name;
//        }

//        public void Study()
//        {
//            Console.WriteLine("Study");
//        }
//    }
#endregion