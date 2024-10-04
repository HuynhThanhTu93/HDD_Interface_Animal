using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDD_Interface_Animal
{
    internal class Dog : Animal, ILiveAnimal
    {
        string ILiveAnimal.BabyCall()
        {
            return "Puppy";
        }
    }
}
