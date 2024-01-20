using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP.Abstract_Factory
{
    internal class HotDrinksMachine
    {
        public enum AvailableDrinks { Tea, Coffee}
        private Dictionary<AvailableDrinks, IHotDrinkFactory> drinks = new Dictionary<AvailableDrinks, IHotDrinkFactory> ();
        public HotDrinksMachine()
        {
            foreach(AvailableDrinks drink in Enum.GetValues(typeof(AvailableDrinks)))
            {
                var factory = (IHotDrinkFactory)Activator.CreateInstance(
                    Type.GetType("Factory_DP.Abstract_Factory." + Enum.GetName(typeof(AvailableDrinks), drink) + "Factory")
                    );
                drinks.Add(drink, factory);
            }
        }
        public IHotDrink MakeDrink(AvailableDrinks drink)
        {
            return drinks[drink].Prepare(100);
        }
    }
}
