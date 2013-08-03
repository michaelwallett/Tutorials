using NServiceBus;
using NServiceBus.Config;
using NServiceBus.MessageMutator;
using NServiceBus.Unicast.Transport;

namespace BusStop.Api.Authentication
{
    public class AccessTokenMutator : IMutateOutgoingTransportMessages, INeedInitialization
    {
        public void MutateOutgoing(object[] messages, TransportMessage transportMessage)
        {
            transportMessage.Headers["access_token"] = "busstop";
        }

        public void Init()
        {
            Configure.Instance.Configurer.ConfigureComponent<AccessTokenMutator>(DependencyLifecycle.InstancePerCall);
        }
    }
}