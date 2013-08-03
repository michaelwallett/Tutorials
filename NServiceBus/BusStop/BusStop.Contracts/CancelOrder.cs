using System;
using NServiceBus;

namespace BusStop.Contracts
{
    public class CancelOrder : IMessage
    {
        public Guid OrderId { get; set; }
    }
}