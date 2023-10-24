namespace Testability
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already shipped");
            }

            order.Shipment = new Shipment()
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = order.DatePlaced.AddDays(1),
            };
        }
    }
}

// this class follows single responsibility principle as it deals only with processing the orders
// also it uses dependency injection technique for compostion design concept