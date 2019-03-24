using System;

namespace Behavioral.ChainOfResponsibility.BrokerChain
{
    public class Demo
    {
        public static void Main()
        {
            var game = new Game();
            var goblin = new Creature(game, "Strong Goblin", 3, 3);
            Console.WriteLine(goblin);

            using (new DoubleAttackModifier(game, goblin))
            {
                Console.WriteLine(goblin);
                using (new IncreaseDefenseModifier(game, goblin))
                {
                    Console.WriteLine(goblin);
                }
            }

            Console.WriteLine(goblin);
        }
    }
}