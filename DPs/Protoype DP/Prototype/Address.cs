using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype_DP.Prototype
{
    internal class Address : IPrototype<Address>
    {
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public Address(string StreetName, int HouseNumber)
        {
            this.StreetName = StreetName;
            this.HouseNumber = HouseNumber; 
        }
        public Address(Address address)
        {
            StreetName = address.StreetName;
            HouseNumber = address.HouseNumber;  
        }

        public Address DeepCopy()
        {
            return new Address(StreetName, HouseNumber);
        }
    }
}
