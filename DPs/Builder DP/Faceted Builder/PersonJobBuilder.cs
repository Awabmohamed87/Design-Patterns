using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Faceted_Builder
{
    internal class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            Person = person;
        }
        public PersonJobBuilder WorksAt(string CompanyName)
        {
            Person.CompanyName = CompanyName;
            return this;
        }
        public PersonJobBuilder WorksAs(string Position)
        {
            Person.Position = Position;
            return this;
        }
        public PersonJobBuilder Takes(int income)
        {
            Person.AnnualIncome = income;
            return this;
        }

    }
}
