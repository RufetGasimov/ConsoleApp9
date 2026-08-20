namespace ConsoleApp8;

public class Celsius
{
    public double Degree { get; set; }

    public static implicit operator Celsius(Kelvin kelvin)
    {
        return new Celsius { Degree = kelvin.Degree - 273.15 };
    }
}
