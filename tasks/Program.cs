using System;
using Zoo;

namespace Zoo
{
   
    public interface IAnimal
    {
        void MakeSound();
        void Move();
    }

   
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Hav-hav");
        }

        public void Move()
        {
            Console.WriteLine("Dog runs");
        }
    }

   
    public class Bird : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Cik-cik");
        }

        public void Move()
        {
            Console.WriteLine("Bird flies");
        }
    }
}
public class Program2
{
    static void Main()
    {
        Dog dog = new Dog();
        Bird bird = new Bird();


        dog.MakeSound();
        bird.MakeSound();

        dog.Move();
        bird.Move();
    }
}

}
