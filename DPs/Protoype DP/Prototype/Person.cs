using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype_DP.Prototype
{
    internal class Person : IPrototype<Person>
    {
        public string[] Names { get; set; }
        public Address Address { get; set; }
        public Person(string[] Names, Address Address)
        {
            this.Names = Names;
            this.Address = Address;
        }
        public Person(Person person)
        {
            Names = (string[])person.Names.Clone();
            this.Address = new Address(person.Address);
        }
        public override string ToString()
        {
            return $"Name: {string.Join(" ", Names)}, Address: {Address.HouseNumber}, {Address.StreetName}";
        }

        public Person DeepCopy()
        {
            return new Person((string[])Names.Clone(), Address.DeepCopy());
        }
    }
}
