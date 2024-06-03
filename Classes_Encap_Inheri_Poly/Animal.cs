using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Encap_Inheri_Poly
{
    internal abstract class Animal
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected double Weight { get; set; }

        protected Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public abstract void doSound();
    }
}
