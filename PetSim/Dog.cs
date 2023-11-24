using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSim
{
    public class Dog
    {
        private int hunger;
        public int Hunger
        {
            private set
            {
                hunger = value;

                CheckHunger();
            }
            get
            {
                return hunger;
            }
        }

        public string Name { get; init; }

        public Dog(string name)
        {
            this.Name = name;
        }
        
        public int Feed()
        {
            Console.WriteLine("Eating...");

            return Hunger -= 20;
        }

        public int Play()
        {
            Console.WriteLine("Playing...");

            return Hunger += 30;
        }

        private void CheckHunger()
        {
            if (hunger > 40 && hunger <= 100)
            {
                Console.WriteLine("Hungry!");
                return;
            }

            if (hunger > 100)
            {
                Console.WriteLine("I DIEEEEED!!!");
                return;
            }
        }
    }
}
