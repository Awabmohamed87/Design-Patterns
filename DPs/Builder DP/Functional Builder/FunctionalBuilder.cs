using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Functional_Builder
{
    public abstract class FunctionalBuilder<TSubject, TSelf> where TSelf : FunctionalBuilder<TSubject, TSelf> where TSubject : new()
    {
        private readonly List<Func<TSubject, TSubject>> actions = new List<Func<TSubject, TSubject>>();
        public TSubject Build() => actions.Aggregate(new TSubject(), (p, f) => f(p));
        
        protected TSelf Do(Action<TSubject> action) => AddAction(action);
        private TSelf AddAction(Action<TSubject> action)
        {
            actions.Add(typ => { action(typ); return typ; });
            return (TSelf)this;
        }
    }
    public sealed class PersonBuilderF : FunctionalBuilder<Person, PersonBuilderF>
    {
        public PersonBuilderF Called(string Name) => Do(p => p.Name = Name);
        
    }
}
