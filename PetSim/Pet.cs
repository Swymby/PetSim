using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSim
{
    internal class Pet
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

        public Pet(string name)
        {
            this.Name = name;
        }

        public int Feed()
        {
            Console.WriteLine("Eating...");

            return Hunger -= 20;
        }

        public virtual int Play()
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
