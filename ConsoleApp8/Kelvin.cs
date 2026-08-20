namespace ConsoleApp8;

public class Kelvin
{
    public double Degree { get; set; }
    public static implicit operator Kelvin(Celsius celsius)
    {
        return new Kelvin { Degree = celsius.Degree + 273.15 };
    }
}
