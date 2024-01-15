using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Builder_Inheritance
{
    internal class PersonBuilder
    {
        public Person person = new Person();
        public Person Build() => person;
    }
}
