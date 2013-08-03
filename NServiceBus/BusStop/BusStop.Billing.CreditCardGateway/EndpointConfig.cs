using BusStop.Authentication;
using NServiceBus;

namespace BusStop.Billing.CreditCardGateway 
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, ISpecifyMessageHandlerOrdering
    {
        public void SpecifyOrder(Order order)
        {
            order.SpecifyFirst<AuthenticationHandler>();
        }
    }
}