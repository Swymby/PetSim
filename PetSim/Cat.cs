using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSim
{
    internal class Cat : Pet
    {
        public Cat(string name) : base(name)
        {
        }

        public override int Play()
        {
            Console.WriteLine("NOPE");

            return Hunger;
        }
    }
}
