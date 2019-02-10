using System;

namespace Creational.Singleton.SingletonInDI
{
    public class Foo
    {
        public EventBroker Broker;

        public Foo(EventBroker broker)
        {
            Broker = broker ?? throw new ArgumentNullException(nameof(broker));
        }
    }
}