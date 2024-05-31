using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Encap_Inheri_Poly
{
    internal class Person
    {
		private string fName;
		private string lName;
        private int age;
        private double height;
		private double weight;

		public string FName
        {
            get { return fName; } 
            set 
            {
                bool invalid = string.IsNullOrWhiteSpace(value);
                if (!invalid && value.Length >= 2 && value.Length <= 10)
                {
                    fName = value;
                } else
                {
                    throw new ArgumentException($"Invalid first name: {value}.");
                }
            }
        }
		public string LName
        {
            get { return lName; }
            set 
            {
                bool invalid = string.IsNullOrWhiteSpace(value);
                if (!invalid && value.Length >= 3 && value.Length <= 15)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException($"Invalid last name: {value}.");
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException($"Invalid age: {value}.");
                }
            }
        }
        public double Height 
        { 
            get { return height; } 
            set 
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException($"Invalid height: {value}.");
                }
            } 
        }
		public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException($"Invalid weight: {value}.");
                }
            }
        }

		public Person(string fName, string lName, int age, double height, double weight)
        {
            FName = fName;
			LName = lName;
            Age = age;
            Height = height;
			Weight = weight;
        }
        public Person(string fName, string lName, int age)
        {
            FName = fName;
            LName = lName;
            Age = age;
        }

    }
}
