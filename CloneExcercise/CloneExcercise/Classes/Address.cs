using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneExcercise.Classes
{
    public class Address
    {
        public string _street { get; set; }
        public int _zip { get; set; }
        public string _city { get; set; }

        public Address(string _street, int _zip, string _city)
        {
            this._street = _street;
            this._city = _city;
            this._zip = _zip;
        }
    }
}
