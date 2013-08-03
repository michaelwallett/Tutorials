using BusStop.Authentication;
using NServiceBus;

namespace BusStop.Backend 
{
	public class EndpointConfig : IConfigureThisEndpoint, AsA_Server, ISpecifyMessageHandlerOrdering
    {
	    public void SpecifyOrder(NServiceBus.Order order)
	    {
            order.SpecifyFirst<AuthenticationHandler>();
	    }
    }
}