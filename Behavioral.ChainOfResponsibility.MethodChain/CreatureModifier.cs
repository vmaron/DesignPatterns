using System;

namespace Behavioral.ChainOfResponsibility.MethodChain
{
    public class CreatureModifier
    {
        protected Creature creature;
        protected CreatureModifier next;

        public CreatureModifier(Creature creature)
        {
            this.creature = creature ?? throw new ArgumentNullException(nameof(creature));
        }

        public void Add(CreatureModifier cm)
        {
            if (next != null) next.Add(cm);
            else next = cm;
        }

        public virtual void Handle()
        {
            next?.Handle();
        }
    }
}