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

        public Animal(string name, int age, double weight, double longestDimension, int numberOfLimbs)
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

        public Horse(string name, int age, double weight, double longestDimension, int numberOfLimbs, bool isShoed)
            : base(name, age, weight, longestDimension, numberOfLimbs)
        {
            IsShoed = isShoed;
        }
        public override void doSound()
        {
            Console.WriteLine("Neigh");
        }
    }
    internal class Dog : Animal
    {
        public bool LikesToBark { get; set; }

        public Dog(string name, int age, double weight, double longestDimension, int numberOfLimbs, bool likesToBark)
            : base(name, age, weight, longestDimension, numberOfLimbs)
        {
            LikesToBark = likesToBark;
        }
        public override void doSound()
        {
            Console.WriteLine("Bark");
        }
    }
    internal class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }

        public Hedgehog(string name, int age, double weight, double longestDimension, int numberOfLimbs, int numberOfSpikes)
            : base(name, age, weight, longestDimension, numberOfLimbs)
        {
            NumberOfSpikes = numberOfSpikes;
        }
        public override void doSound()
        {
            Console.WriteLine("Grunts and snuffles");
        }
    }
    internal class Worm : Animal
    {
        public bool IsPoisonus { get; set; }

        public Worm(string name, int age, double weight, double longestDimension, int numberOfLimbs, bool isPoisonus)
            : base(name, age, weight, longestDimension, numberOfLimbs)
        {
            IsPoisonus = isPoisonus;
        }
        public override void doSound()
        {
            Console.WriteLine("Munches");
        }
    }
    internal class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name, int age, double weight, double longestDimension, int numberOfLimbs, double wingSpan)
            : base(name, age, weight, longestDimension, numberOfLimbs)
        {
            WingSpan = wingSpan;
        }
        public override void doSound()
        {
            Console.WriteLine("Chirps");
        }
    }
    internal class Wolf : Animal
    {
        public bool LikesToHowl { get; set; }

        public Wolf(string name, int age, double weight, double longestDimension, int numberOfLimbs, bool likesToHowl)
            : base(name, age, weight, longestDimension, numberOfLimbs)
        {
            LikesToHowl = likesToHowl;
        }
        public override void doSound()
        {
            Console.WriteLine("Howls and growls");
        }
    }
    internal class Pelican : Bird
    {

        public Pelican(string name, int age, double weight, double longestDimension, int numberOfLimbs, double wingSpan)
            : base(name, age, weight, longestDimension, numberOfLimbs, wingSpan)
        {
            
        }
    }
    internal class Flamingo : Bird
    {

        public Flamingo(string name, int age, double weight, double longestDimension, int numberOfLimbs, double wingSpan)
            : base(name, age, weight, longestDimension, numberOfLimbs, wingSpan)
        {

        }
    }
    internal class Swan : Bird
    {

        public Swan(string name, int age, double weight, double longestDimension, int numberOfLimbs, double wingSpan)
            : base(name, age, weight, longestDimension, numberOfLimbs, wingSpan)
        {

        }
    }
}
