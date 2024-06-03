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
        protected double LongestDimension { get; set; }
        protected int NumberOfLimbs { get; set; }

        protected Animal(string name, int age, double weight, double longestDimension, int numberOfLimbs)
        {
            Name = name;
            Age = age;
            Weight = weight;
            LongestDimension = longestDimension;
            NumberOfLimbs = numberOfLimbs;
        }

        public abstract void doSound();
    }

    internal class Horse : Animal
    { 
        public bool IsShoed { get; set; }
    }
    internal class Dog : Animal
    {
        public bool LikesToBark { get; set; }
    }
    internal class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }
    }
    internal class Worm : Animal
    {
        public bool IsPoisonus { get; set; }
    }
    internal class Bird : Animal
    {
        public double WingSpan { get; set; }
    }
    internal class Wolf : Animal
    {
        public bool LikesToHowl { get; set; }
    }
}
