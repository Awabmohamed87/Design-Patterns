using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Faceted_Builder
{
    internal class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            Person = person;
        }
        public PersonAddressBuilder LivesAt(string Address)
        {
            Person.StreetAddres = Address;
            return this;
        }
        public PersonAddressBuilder PostalCode(string PostalCode)
        {
            Person.PostalCode = PostalCode;
            return this;
        }
        public PersonAddressBuilder City(string City)
        {
            Person.City = City;
            return this;
        }
    }
}
