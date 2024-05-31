using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Encap_Inheri_Poly
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(string fname, string lname, int age, double height, double weight)
        {
            return new Person(fname, lname, age, height, weight);
        }   
    }
}
