using Testability;

namespace TestabilityTesting;

public class OrderProcessorTest
{
    [SetUp]
    public void Setup()
    {
    }

    //METHODNAME_CONDITION_EXPECTATION
    [Test]
    
    public void Process_OrderIsShipped_ThrowsException()
    {
        OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        Order order = new Order()
        {
            Shipment = new Shipment() { },
            DatePlaced = DateTime.Now,
        };
        Assert.Throws<InvalidOperationException>(() => orderProcessor.Process(order));
    }

    [Test]

    public void Process_OrderIsNotShipped()
    {
        OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        Order order = new Order()
        {
            //DatePlaced = DateTime.Now,
        };
        orderProcessor.Process(order);          // here also coupling is there but not extremely tight

    }
}

public class FakeShippingCalculator : IShippingCalculator
{
    public float CalculateShipping(Order order)
    {
        return 1;
    }
}