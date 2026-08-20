namespace ConsoleApp8;
public class Courier
{
    public static int _id = 0;
    public int Id { get; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; }

    public Courier(bool isAvailable, string name)
    {
        _id++;
        Id = _id;
        IsAvailable = isAvailable;
        Name = name;
    }
}

