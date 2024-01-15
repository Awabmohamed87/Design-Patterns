using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Functional_Builder
{
    internal sealed class PersonBuilder
    {
        private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();
        public PersonBuilder Called(string Name) => Do(P => P.Name = Name);
        public Person Build() => actions.Aggregate(new Person(), (p,f) => f(p));
        public PersonBuilder Do(Action<Person> action) => AddAction(action);
        private PersonBuilder AddAction(Action<Person> action)
        {
            actions.Add(p => { action(p); return p; });
            return this;
        }
    }
}
