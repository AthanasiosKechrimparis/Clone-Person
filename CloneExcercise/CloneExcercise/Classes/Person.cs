using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneExcercise.Classes
{
    public class Person
    {
        public DateTime _dob { get; set; }
        public double _weight { get; set; }

        public Address _address { get; set; }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DClone() // This is the Deep Clone
        {
            Person person = (Person)this.MemberwiseClone();
            person._address = new Address(_address._street, _address._zip, _address._city);
            person._dob = _dob;
            person._weight = _weight;
            return person;
        }
    }
}
}
