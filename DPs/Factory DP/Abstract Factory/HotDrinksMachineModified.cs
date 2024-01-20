using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP.Abstract_Factory
{
    internal class HotDrinksMachineModified
    {
        private List<(string, IHotDrinkFactory)> drinks = new List<(string, IHotDrinkFactory)> ();
        public HotDrinksMachineModified()
        {
            foreach(var variable in typeof(HotDrinksMachineModified).Assembly.GetTypes())
            {
                // variable inhirets IHotDrinkFactory
                if (typeof(IHotDrinkFactory).IsAssignableFrom(variable) && !variable.IsInterface)
                    drinks.Add((variable.Name.Replace("Factory", string.Empty), (IHotDrinkFactory)Activator.CreateInstance(variable)));
            }
        }
        public IHotDrink MakeDrink(string drinkName)
        {
            return drinks.FirstOrDefault(drink => drink.Item1 == drinkName).Item2.Prepare(100);
        }
    }
}
