namespace ConsoleApp8;

public class CargoOrder
{
    public static int _id = 0;
    public int Id { get; }
    public int CustomerId { get; set; }
    public int CourierId { get; set; }
    public double TotalPrice { get; set; }
    public OrderStatus Status { get; private set; }
    public DateTime CreatedAt { get; }

    public CargoOrder(int customerId, int courierId, double totalPrice)
    {
        _id++;
        Id = _id;

        CustomerId = customerId;
        CourierId = courierId;
        TotalPrice = totalPrice;
        Status = OrderStatus.Created;
        CreatedAt = DateTime.Now;
    }

    public void UpdateStatus(OrderStatus status)
    {
        if (Status == OrderStatus.Delivered ||
            Status == OrderStatus.Cancelled)
        {
            throw new Exception("Bu sifarişin statusu dəyişdirilə bilməz");
        }

        Status = status;
    }

    public interface ICargoService
    {
        void AddCustomer(Customer customer);

        void AddCourier(Courier courier);

        void CreateOrder(CargoOrder order);

        void CompleteOrder(int id);
    }



}
