using Builder_DP.Builder;
using Builder_DP.Builder_Inheritance;
using Builder_DP.Stepwise_Builder;
using Builder_DP.Functional_Builder;
using Builder_DP.Faceted_Builder;

namespace BuilderDB
{
    public class BuilderDB
    {
        static void Main(string[] args)
        {
            //--------------------------------------
            var builder = new HtmlBuilder("ul");
            var nestedElement = new HtmlElement("li", "Hello");
            nestedElement.Elements.Add(new HtmlElement("p", "Nested"));
            builder.AddChild(nestedElement).AddChild(new HtmlElement("li", "World"));
            //Console.WriteLine(builder.ToString());
            //------------------------------------
            var me = Builder_DP.Builder_Inheritance.Person.New.Called("Awab").Works("Progarammer").Build();
            //Console.WriteLine(me.ToString());
            //--------------------------------------
            Car car = CarBuilder.Create().WithType(CarType.saden).WithWheels(16).Build();
            //Console.WriteLine(car.ToString());
            //--------------------------------------
            var peson = new Builder_DP.Functional_Builder.PersonBuilder().Called("Awab").WorksAs("programmer").Build();
            //Console.WriteLine(peson.ToString());
            var person = new PersonBuilderF().Called("Awab").Build();
            //Console.WriteLine(person.ToString());
            //--------------------------------------
            Builder_DP.Faceted_Builder.Person person2 = new Builder_DP.Faceted_Builder.PersonBuilder().Lives.LivesAt("123sad").PostalCode("15789").City("Cairo")
                .Works.WorksAt("HIG").WorksAs("Programmer").Takes(1231985);
            Console.WriteLine(person2.ToString());

        }
    }
}