using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allat
{
    abstract class Animal
    {
        public abstract void AnimalSound();
        public void Sleep()
        {
            Console.WriteLine("z");
        }
       
        
    }

    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Rőff");
        }
    }

    class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Miau");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();
            pig.AnimalSound();

            Cat cat = new Cat();
            cat.AnimalSound();

            Console.ReadKey();
        }
    }
    
}
