namespace ConsoleApp8;

internal class CargoService
{
    public List<Customer> Customers { get; set; } = new List<Customer>();
    public List<Courier> Couriers { get; set; } = new List<Courier>();
    public List<CargoOrder> Orders { get; set; } = new List<CargoOrder>();

    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }

    public void AddCourier(Courier courier)
    {
        Couriers.Add(courier);
    }

    public void CreateOrder(CargoOrder order)
    {
        Customer customer = Customers.Find(x => x.Id == order.CustomerId);

        if (customer == null)
        {
            throw new Exception("Customer tapilmadi");
        }

        Courier courier = Couriers.Find(x => x.Id == order.CourierId);

        if (courier == null)
        {
            throw new Exception("Courier tapilmadi");
        }

        if (courier.IsAvailable == false)
        {
            throw new Exception("Courier musguldur");
        }

        Orders.Add(order);

        courier.IsAvailable = false;
    }

    public void CompleteOrder(int id)
    {
        CargoOrder order = Orders.Find(x => x.Id == id);

        if (order == null)
        {
            throw new Exception("Order tapilmadi");
        }

        order.UpdateStatus(OrderStatus.Delivered);

        Courier courier = Couriers.Find(x => x.Id == order.CourierId);

        courier.IsAvailable = true;
    }
}

