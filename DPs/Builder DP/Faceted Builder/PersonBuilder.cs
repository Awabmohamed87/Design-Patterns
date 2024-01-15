using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Faceted_Builder
{
    internal class PersonBuilder //facade
    {
        //reference
        protected Person Person = new Person();
        public PersonJobBuilder Works => new PersonJobBuilder(Person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(Person);

        public static implicit operator Person(PersonBuilder builder) => builder.Person;
    }
}
