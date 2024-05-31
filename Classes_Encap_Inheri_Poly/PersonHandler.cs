using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Encap_Inheri_Poly
{
    internal class PersonHandler
    {
        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }
        public void SetLName(Person pers, string lName)
        {
            pers.LName = lName;
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
        
        public Person CreatePerson(string fname, string lname, int age, double height, double weight)
        {
            return new Person(fname, lname, age, height, weight);
        }   
    }
}
