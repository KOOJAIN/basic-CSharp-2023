using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace number_5_App
{
    interface IAnimal
    {
        void Eat();
        void Sleep();
        void Sound();
    }

    abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public byte Age { get; set; }

        public void Eat() 
        {
            Console.WriteLine($"{Name}이(가) 냠냠");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name}잡니다");
        }
        public abstract void Sound();
    }
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine($"{Name}가 왈왈");
        }
    }
    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine($"{Name}가 냥냥");
        }
    }
    class Horse : Animal
    {
        public override void Sound()
        {
            Console.WriteLine($"{Name}가 호올스");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(); 
            dog.Name = "멍멍스";
            dog.Age = 1;
            dog.Eat();
            dog.Sleep();
            dog.Sound();

            Cat cat = new Cat();
            cat.Name = "냥";
            cat.Age = 2;
            cat.Eat();
            cat.Sleep();
            cat.Sound();

            Horse horse = new Horse();
            horse.Name = "힝";
            horse.Age = 3;
            horse.Eat();
            horse.Sleep();
            horse.Sound();


        }
    }
}
