using System;

namespace Behavioral.ChainOfResponsibility.BrokerChain
{
    public abstract class CreatureModifier : IDisposable
    {
        protected Creature creature;
        protected Game game;

        protected CreatureModifier(Game game, Creature creature)
        {
            this.game = game;
            this.creature = creature;
            game.Queries += Handle;
        }

        public void Dispose()
        {
            game.Queries -= Handle;
        }

        protected abstract void Handle(object sender, Query q);
    }
}