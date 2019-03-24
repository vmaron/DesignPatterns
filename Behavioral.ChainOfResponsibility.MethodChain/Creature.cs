using System;

namespace Behavioral.ChainOfResponsibility.MethodChain
{
    public class Creature
    {
        public int Attack, Defense;
        public string Name;

        public Creature(string name, int attack, int defense)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Attack = attack;
            Defense = defense;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
        }
    }
}