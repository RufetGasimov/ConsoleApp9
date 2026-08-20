namespace ConsoleApp8;

public class Customer
{
    public static int _id = 0;
    public int Id { get; }
    public string Name { get; set; }
    public string City { get; set; }

    public Customer(string name, string city)
    {
        _id++;
        Id = _id;
        Name = name;
        City = city;
    }
}
