using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloneExcercise.Classes;

namespace CloneExcercise
{
    class Program
    {
        public static void DisplayValues(Classes.Person p, string personDescription)
        {
            Console.WriteLine(personDescription + "\n" + DateTime.Parse(p._dob.ToShortDateString()).ToString());
            Console.WriteLine(double.Parse(p._weight.ToString()));
            Console.WriteLine(p._address._city);
            Console.WriteLine(p._address._street);
            Console.WriteLine(p._address._zip + "\n");
        }
        static void Main(string[] args)
        {
            //Create the Original Person
            Person originalPerson = new Classes.Person();
            originalPerson._dob = DateTime.Now;
            originalPerson._weight = 203.8;
            originalPerson._address = new Classes.Address("Seebladsgade", 5000, "Odense");


            //Here clone the original Person to the Clone Person
            Person personClone = originalPerson.DClone();

            //Display the persons in the Console
            DisplayValues(originalPerson, "Original Person");
            DisplayValues(personClone, "Clone Person");


            Console.Read();
        }
    }
}
