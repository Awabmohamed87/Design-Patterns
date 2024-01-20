

using Factory_DP.Abstract_Factory;
using Factory_DP.Async_Factory;
using Factory_DP.Factory;
using Factory_DP.Tracking_Factory;

namespace FactoryDP
{
    public class FactoryDP
    {
        public static async Task Main(string[] args)
        {
            //var point = PointFactory.NewCartesianPoint(0.5, 0.5);
            //var point2 = PointFactory.NewPolarPoint(0.5, 0.5);
            //var res = await AsyncFactory.CreateInstanceAsync();

            //var fac = new TrackingThemeFactory();
            //var theme1 = fac.CreateTheme(isDark: false);
            //var theme2 = fac.CreateTheme(isDark: true);
            //Console.WriteLine(fac.Info);

            //var fac = new ReplaceableFactory();
            //var theme1 = fac.CreateTheme(isDark: false);
            //await Console.Out.WriteLineAsync(theme1.val.BackgroundColor);
            //fac.Replace(isDark: true);
            //await Console.Out.WriteLineAsync(theme1.val.BackgroundColor);

            //var fac = Point.Factory.NewPolarPoint(0, 0);
            //await Console.Out.WriteLineAsync(fac.ToString());


            //var machine = new HotDrinksMachine();
            //var drink11 = machine.MakeDrink(HotDrinksMachine.AvailableDrinks.Tea);
            //drink11.Consume();

            var machineModified = new HotDrinksMachineModified();
            var drink = machineModified.MakeDrink("Coffee");
            drink.Consume();

        }
    }
}