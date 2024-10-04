using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDD_Interface_Animal
{
    internal class Cat : Animal, ILiveAnimal
    {
        string ILiveAnimal.BabyCall()
        {
            return "Kitten";
        }
    }
}
