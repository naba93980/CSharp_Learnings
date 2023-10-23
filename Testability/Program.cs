namespace Testability
{
    public class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                DatePlaced = DateTime.Now,
                TotalPrice = 100f,
            };

            OrderProcessor orderProcessor = new OrderProcessor(new ShippingCalculator());
            orderProcessor.Process(order);
        }
    }
}