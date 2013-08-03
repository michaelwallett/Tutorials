using System;
using NServiceBus;
using NServiceBus.Config;
using NServiceBus.UnitOfWork;
using Raven.Client;
using Raven.Client.Document;

namespace BusStop.Backend
{
    public class RavenBootstrapper : INeedInitialization
    {
        public void Init()
        {
            var store = new DocumentStore
                {
                    Url = "http://localhost:8080"
                };

            store.Initialize();

            Configure.Instance.Configurer.ConfigureComponent<IDocumentStore>(() => store, DependencyLifecycle.SingleInstance);

            Configure.Instance.Configurer.ConfigureComponent(() => Configure.Instance.Builder.Build<IDocumentStore>().OpenSession(), DependencyLifecycle.InstancePerUnitOfWork);

            Configure.Instance.Configurer.ConfigureComponent<RavenUnitOfWork>(DependencyLifecycle.InstancePerUnitOfWork);
        }
    }

    public class RavenUnitOfWork : IManageUnitsOfWork
    {
        public IDocumentSession Session { get; set; }

        public void Begin()
        {
            
        }

        public void End(Exception ex = null)
        {
            if (ex == null)
            {
                Session.SaveChanges();
            }
        }
    }
}