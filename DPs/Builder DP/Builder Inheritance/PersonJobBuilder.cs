using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Builder_Inheritance
{
    internal class PersonJobBuilder<T> : PersonInfoBuilder<PersonJobBuilder<T>> where T : PersonJobBuilder<T>
    {
        public T Works(string position)
        {
            person.Position = position;
            return (T) this;
        }
    }
}
