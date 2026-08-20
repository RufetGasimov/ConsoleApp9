namespace ConsoleApp8;

public interface ICargoService
{
    void AddCustomer(Customer customer);

    void AddCourier(Courier courier);

    void CreateOrder(CargoOrder order);

    void CompleteOrder(int id);
}
