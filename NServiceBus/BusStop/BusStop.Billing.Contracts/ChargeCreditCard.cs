using System;
using NServiceBus;

namespace BusStop.Billing.Contracts
{
    public class ChargeCreditCard : IMessage
    {
        public Guid CustomerId { get; set; }
        public decimal Amount { get; set; }
    }

    public class CreditCardCharged : IMessage
    {
        public Guid CustomerId { get; set; }
        public string Receipt { get; set; }
    }
}