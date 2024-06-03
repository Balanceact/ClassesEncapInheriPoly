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
        // 3.3.14: Answer: We'd put it here in the Animal class so it can easily be implemented and reached by all the animals.

        public Animal(string name, int age, double weight, double longestDimension, int numberOfLimbs)
        {
            Name = name;
            Age = age;
            Weight = weight;
            LongestDimension = longestDimension;
            NumberOfLimbs = numberOfLimbs;
        }

        public abstract void doSound();

        public abstract string Stats();
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
        public override string Stats()
        {
            return $"The {this.GetType().Name} named {this.Name} is {this.Age} years of age, weighs {this.Weight}kg, its length/height is {this.LongestDimension}m and it has {this.NumberOfLimbs} limbs. It also has the following properties: has horseshooes: {this.IsShoed}.";
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
        public override string Stats()
        {
            return $"The {this.GetType().Name} named {this.Name} is {this.Age} years of age, weighs {this.Weight}kg, its length/height is {this.LongestDimension}m and it has {this.NumberOfLimbs} limbs. It also has the following properties: likes to bark: {this.LikesToBark}.";
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
        public override string Stats()
        {
            return $"The {this.GetType().Name} named {this.Name} is {this.Age} years of age, weighs {this.Weight}kg, its length/height is {this.LongestDimension}m and it has {this.NumberOfLimbs} limbs. It also has the following properties: has this many spikes: {this.NumberOfSpikes}.";
        }
    }
    internal class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public Worm(string name, int age, double weight, double longestDimension, int numberOfLimbs, bool isPoisonous)
            : base(name, age, weight, longestDimension, numberOfLimbs)
        {
            IsPoisonous = isPoisonous;
        }
        public override void doSound()
        {
            Console.WriteLine("Munches");
        }
        public override string Stats()
        {
            return $"The {this.GetType().Name} named {this.Name} is {this.Age} years of age, weighs {this.Weight}kg, its length/height is {this.LongestDimension}m and it has {this.NumberOfLimbs} limbs. It also has the following properties: is poisonous to eat: {this.IsPoisonous}.";
        }
    }
    internal class Bird : Animal
    {
        public double WingSpan { get; set; }
        // 3.3.13: Answer: We'd put it here in the Bird class so it can easily be implemented and reached by all the birds.

        public Bird(string name, int age, double weight, double longestDimension, int numberOfLimbs, double wingSpan)
            : base(name, age, weight, longestDimension, numberOfLimbs)
        {
            WingSpan = wingSpan;
        }
        public override void doSound()
        {
            Console.WriteLine("Chirps");
        }
        public override string Stats()
        {
            return $"The {this.GetType().Name} named {this.Name} is {this.Age} years of age, weighs {this.Weight}kg, its length/height is {this.LongestDimension}m and it has {this.NumberOfLimbs} limbs. It also has the following properties: has a wingspen of: {this.WingSpan}m.";
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
        public override string Stats()
        {
            return $"The {this.GetType().Name} named {this.Name} is {this.Age} years of age, weighs {this.Weight}kg, its length/height is {this.LongestDimension}m and it has {this.NumberOfLimbs} limbs. It also has the following properties: likes to howl: {this.LikesToHowl}.";
        }
    }
    internal class Pelican : Bird
    {
        public double BeakSize { get; set; }

        public Pelican(string name, int age, double weight, double longestDimension, int numberOfLimbs, double wingSpan, double beakSize)
            : base(name, age, weight, longestDimension, numberOfLimbs, wingSpan)
        {
            BeakSize = beakSize;
        }
        public override string Stats()
        {
            return $"The {this.GetType().Name} named {this.Name} is {this.Age} years of age, weighs {this.Weight}kg, its length/height is {this.LongestDimension}m and it has {this.NumberOfLimbs} limbs. It also has the following properties: has a wingspen of: {this.WingSpan}m and a beaksize of {this.BeakSize}m.";
        }
    }
    internal class Flamingo : Bird
    {
        public bool LikesToStandOnOneLeg;
        public Flamingo(string name, int age, double weight, double longestDimension, int numberOfLimbs, double wingSpan, bool likesToStandOnOneLeg)
            : base(name, age, weight, longestDimension, numberOfLimbs, wingSpan)
        {
            LikesToStandOnOneLeg = likesToStandOnOneLeg;
        }
        public override string Stats()
        {
            return $"The {this.GetType().Name} named {this.Name} is {this.Age} years of age, weighs {this.Weight}kg, its length/height is {this.LongestDimension}m and it has {this.NumberOfLimbs} limbs. It also has the following properties: has a wingspen of: {this.WingSpan}m, likes to stand on only one leg: {this.LikesToStandOnOneLeg}.";
        }
    }
    internal class Swan : Bird
    {
        public bool IsUglyDuckling;
        public Swan(string name, int age, double weight, double longestDimension, int numberOfLimbs, double wingSpan, bool isUglyDuckling)
            : base(name, age, weight, longestDimension, numberOfLimbs, wingSpan)
        {
            IsUglyDuckling = isUglyDuckling;
        }
        public override string Stats()
        {
            return $"The {this.GetType().Name} named {this.Name} is {this.Age} years of age, weighs {this.Weight}kg, its length/height is {this.LongestDimension}m and it has {this.NumberOfLimbs} limbs. It also has the following properties: has a wingspen of: {this.WingSpan}m, is an ugly duckling: {this.IsUglyDuckling}.";
        }
    }
    internal class Wolfman : Wolf, IPerson
    {
        

        public Wolfman(string name, int age, double weight, double longestDimension, int numberOfLimbs, bool likesToHowl)
            : base(name, age, weight, longestDimension, numberOfLimbs, likesToHowl)
        {
            
        }
        public void Talk()
        {
            Console.WriteLine("What? You think I run around on all four like a dog? Ofcourse not! *Procedes to bark and howl*");
        }
    }
}
