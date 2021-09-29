using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassenUppgift
{

    class Person
    {
        
        public Backpack Backpack { get; set; }
        public int Speed { get; set; } = 0;

        public Person()
        {
            Backpack = new Backpack(); //why to make new instance if 
        }
        public void Run()
        {
            Console.WriteLine($"The person runs at {Speed} km/h!");
        }

        public void LookInBag()
        {
            foreach (var item in Backpack.Snacks)
            {
                Console.WriteLine($"The person looks in the {item}");
            }            
        }
        public void Eat()
        {
            for (int i = 0; i <= new Random().Next(Backpack.Snacks.Length) ; i++)
            {
                Console.WriteLine($"The person takes a bite {Backpack.Snacks[i]}");
            }
        }
    }
}
