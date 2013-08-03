using BusStop.Billing.Contracts;
using NServiceBus;

namespace BusStop.Billing.CreditCardGateway
{
    public class ChargeCreditCardHandler : IHandleMessages<ChargeCreditCard>
    {
        public IBus Bus { get; set; }
        public ICreditCardService CreditCardService { get; set; }

        public void Handle(ChargeCreditCard message)
        {
            string receipt = CreditCardService.Charge(message.CustomerId, message.Amount);

            Bus.Reply(new CreditCardCharged { CustomerId = message.CustomerId, Receipt = receipt });
        }
    }
}