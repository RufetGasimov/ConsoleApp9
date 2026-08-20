using System.Diagnostics.Metrics;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kelvin kelvin = new Kelvin { Degree = 275 };
            Celsius celsius = kelvin;

            Console.WriteLine(celsius.Degree);

            Valyuta valyuta = new Valyuta();
            double val = valyuta.Exchage(Valyuta.Currecy.Usd, 17);
            Console.WriteLine(val);


            Customer customer = new Customer("Rufat", "Baku");

            Courier courier = new Courier(true, "Ali");

            CargoOrder order = new CargoOrder(
                customer.Id,
                courier.Id,
                100);
        }
    }
}
