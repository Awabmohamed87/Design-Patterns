using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Faceted_Builder
{
    public class Person
    {
        //adress
        public string StreetAddres, PostalCode, City;

        //employment
        public string CompanyName, Position;
        public float AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAddres)}:{StreetAddres}, {nameof(PostalCode)}:{PostalCode}, {nameof(City)}:{City}, {nameof(CompanyName)}:{CompanyName}, {nameof(Position)}:{Position}, {nameof(AnnualIncome)}:{AnnualIncome}";
        }
    }
}
