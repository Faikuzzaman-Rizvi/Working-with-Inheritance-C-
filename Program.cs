using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    public abstract class PaymentMethod
    {
        public void Validate()
        {
            Console.WriteLine("Validating Payment...");
        }
        public abstract void Pay(decimal amount);
    }

    public class CreditCard : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"paying {amount} using credit card");
        }
    }

    public class PayPal : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"paying {amount} using PayPal");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod p1 = new CreditCard();
            p1.Validate();
            p1.Pay(1000);
            PaymentMethod p2 = new PayPal();
            p2.Validate();
            p2.Pay(500);
        }
    }
}


//-------------->Topic-1: Inheritance Basics — Base & Derived Class ডিক্লেয়ার করা---------->
//public class Animal
//{
//    public void Eat()
//    {
//        Console.WriteLine("Animal is eating");
//    }

//    public void Sleep()
//    {
//        Console.WriteLine("Animal is sleeping");
//    }
//}

//public class Dog : Animal
//{

//    public void Bark()
//    {
//        Console.WriteLine("Dog is Barking!");
//    }
//}

//public class Whale : Animal
//{
//    public void Swim()
//    {
//        Console.WriteLine("Whale is swiming!");
//    }
//}

//Dog dog = new Dog();
//dog.Eat();
//dog.Sleep();
//dog.Bark();

//Whale whale = new Whale();
//whale.Sleep();
//whale.Swim();


//-------------->Topic-2: Method Hiding vs Overriding (new, virtual, override)---------->
//Goal: override বনাম new পার্থক্য console-এ প্রমাণ করা।
//public class Animal
//{
//    public void Move()
//    {
//        Console.WriteLine("Animal is moving");
//    }

//    public virtual void Speek()
//    {
//        Console.WriteLine("Animal Sound");
//    }
//}

//public class Dog : Animal
//{
//    public override void Speek()
//    {
//        Console.WriteLine("Dog says Bhaw! Bhaw!");
//    }

//    public new void Move() 
//    {
//        Console.WriteLine("Dog is runing");        
//    }
//}

//Dog dog = new Dog();
//  dog.Move();
//  dog.Speek();

//  Animal animal = new Animal();
//  animal.Move();
//  animal.Speek();

//public class Vehicle
//{
//    public virtual void Drive() => Console.WriteLine("Vehicle is driving");
//    public void Start() => Console.WriteLine("Vehicle started");
//}

//public class Car : Vehicle
//{
//    public override void Drive() => Console.WriteLine("Car is driving on the road");
//    public new void Start() => Console.WriteLine("Car engine started");
//}

//Car car = new Car();
//car.Drive();
//car.Start();

//Vehicle vehicle = car;
//// Override → runtime polymorphism: Car-এর ভার্সন চলে
//vehicle.Drive();
//// Hiding (new) → base reference type-এ Vehicle ভার্সন চলে
//vehicle.Start();


//-------------->Topic-3: Base Constructor & Initialization Order---------->

//public class Person
//{
//    public Person()
//    {
//        Console.WriteLine("Person Constructor called");
//    }

//    public Person(string name)
//    {
//        Console.WriteLine($"Person Constructor: {name}");
//    }
//}

//public class Student : Person
//{
//    public Student()
//    {
//        Console.WriteLine("Student Constructor called");
//    }

//    public Student(string name) : base(name)
//    {
//        Console.WriteLine($"Student Constructor: {name}");
//    }
//}

//Console.WriteLine("Enter your name: ");
//string name = Console.ReadLine();
//Console.Write("\n");
//Student student = new Student("\n");

//Student student1 = new Student(name+"\n");


//-------------->Topic-4: Abstract Classes---------->

//public abstract class Animal
//{
//    public abstract void Speak();
//}

//public class Dog : Animal
//{
//    public override void Speak() 
//    {
//        Console.WriteLine("Dog says Woof");
//    }
//}

//public class Cat : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Cat says Meow");
//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        Animal a1 = new Dog();
//        a1.Speak();
//        Animal a2 = new Cat();
//        a2.Speak();


//    }
//}


//-------------->Abstract with Common + Abstract Behavior---------->

//public abstract class PaymentMethod
//{
//    public void Validate()
//    {
//        Console.WriteLine("Validating Payment...");
//    }
//    public abstract void Pay(decimal amount);
//}

//public class CreditCard : PaymentMethod
//{
//    public override void Pay(decimal amount)
//    {
//        Console.WriteLine($"paying {amount} using credit card");
//    }
//}

//public class PayPal : PaymentMethod
//{
//    public override void Pay(decimal amount)
//    {
//        Console.WriteLine($"paying {amount} using PayPal");

//    }
//}

//PaymentMethod p1 = new CreditCard();
//p1.Validate();
//p1.Pay(1000);
//PaymentMethod p2 = new PayPal();
//p2.Validate();
//p2.Pay(500);