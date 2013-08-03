using NServiceBus;
using System.Windows;
using NServiceBus.Installation.Environments;

namespace BusStop.Backoffice
{
    public partial class App : Application
    {
        public static IBus Bus { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Bus = Configure
                .With()
                .Log4Net()
                .DefaultBuilder()
                .XmlSerializer()
                .MsmqTransport()
                .UnicastBus()
                .CreateBus()
                .Start(() => Configure.Instance.ForInstallationOn<Windows>().Install());

            Bus.OutgoingHeaders["access_token"] = "busstop";
        }
    }
}
