using System;

namespace Behavioral.ChainOfResponsibility.BrokerChain
{
    public class Creature
    {
        private readonly int attack;
        private readonly int defense;
        private readonly Game game;
        public string Name;

        public Creature(Game game, string name, int attack, int defense)
        {
            this.game = game ?? throw new ArgumentNullException(nameof(game));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            this.attack = attack;
            this.defense = defense;
        }

        public int Attack
        {
            get
            {
                var q = new Query(Name, Query.Argument.Attack, attack);
                game.PerformQuery(this, q);
                return q.Value;
            }
        }

        public int Defense
        {
            get
            {
                var q = new Query(Name, Query.Argument.Defense, defense);
                game.PerformQuery(this, q);
                return q.Value;
            }
        }

        public override string ToString() // no game
        {
            return $"{nameof(Name)}: {Name}, {nameof(attack)}: {Attack}, {nameof(defense)}: {Defense}";
            //                                                 ^^^^^^^^ using a property    ^^^^^^^^^
        }
    }
}