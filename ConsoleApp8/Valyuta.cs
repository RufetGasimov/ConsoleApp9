namespace ConsoleApp8;
internal class Valyuta
{
    public enum Currecy
    {
        Usd,
        Eur,
        Try
    }

    public double Exchage(Enum value, double azn)
    {
        if (value is not Currecy)
            return 0;

        if ((Currecy)value == Currecy.Usd)
            return azn * 0.59;

        else if ((Currecy)value == Currecy.Eur)
            return azn * 0.51;

        else if ((Currecy)value == Currecy.Try)
            return azn * 24.5;

        return 0;

    }

}

