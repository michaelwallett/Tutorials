using System;
using NServiceBus;
using NServiceBus.Config;

namespace BusStop.Billing.CreditCardGateway
{
    public interface ICreditCardService
    {
        string Charge(Guid customerId, decimal amount);
    }

    public class CreditCardService : ICreditCardService, INeedInitialization
    {
        public string Charge(Guid customerId, decimal amount)
        {
            Console.WriteLine("Customer " + customerId + " charged with: " + amount);

            return Guid.NewGuid().ToString();
        }

        public void Init()
        {
            Configure.Instance.Configurer.ConfigureComponent<CreditCardService>(DependencyLifecycle.InstancePerCall);
        }
    }
}