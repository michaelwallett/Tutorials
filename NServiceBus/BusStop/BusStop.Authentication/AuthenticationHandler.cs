using System;
using NServiceBus;

namespace BusStop.Authentication
{
    public class AuthenticationHandler : IHandleMessages<IMessage>
    {
        public IBus Bus { get; set; }

        public void Handle(IMessage message)
        {
            string token = message.GetHeader("access_token");

            if (token != "busstop")
            {
                Console.WriteLine("User not authenticated.");

                Bus.DoNotContinueDispatchingCurrentMessageToHandlers();

                return;
            }

            Console.WriteLine("User authenticated.");
        }
    }
}