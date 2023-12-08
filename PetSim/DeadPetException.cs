using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSim
{
    public class DeadPetException : Exception
    {
        public DeadPetException() : base("Pet died!") { }
    }
}
