using BusStop.Billing.Contracts;
using BusStop.Contracts;
using NServiceBus;
using Raven.Client;
using System;

namespace BusStop.Backend
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        public IBus Bus { get; set; }
        public IDocumentSession Session { get; set; }

        public void Handle(PlaceOrder message)
        {
            //throw new Exception("Error!");

            Session.Store(new Order { OrderId = message.OrderId });

            Bus.Send(new ChargeCreditCard { CustomerId = message.CustomerId, Amount = 100 });

            Console.WriteLine("Order received: " + message.OrderId);
        }
    }

    public class Order
    {
        public Guid OrderId { get; set; }
    }
}