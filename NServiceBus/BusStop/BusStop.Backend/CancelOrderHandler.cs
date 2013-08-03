using System;
using BusStop.Contracts;
using NServiceBus;

namespace BusStop.Backend
{
    public class CancelOrderHandler : IHandleMessages<CancelOrder>
    {
        public IBus Bus { get; set; }

        public void Handle(CancelOrder message)
        {
            Console.WriteLine("Order cancelled: " + message.OrderId);

            Bus.Return(CommandStatus.Success);
        }
    }
}