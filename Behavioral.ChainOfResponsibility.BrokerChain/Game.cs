using System;

namespace Behavioral.ChainOfResponsibility.BrokerChain
{
    public class Game // mediator pattern
    {
        public event EventHandler<Query> Queries; // effectively a chain

        public void PerformQuery(object sender, Query q)
        {
            Queries?.Invoke(sender, q);
        }
    }
}