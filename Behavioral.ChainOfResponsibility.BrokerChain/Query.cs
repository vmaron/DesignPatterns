using System;

namespace Behavioral.ChainOfResponsibility.BrokerChain
{
    // command query separation is being used here
    public class Query
    {
        public enum Argument
        {
            Attack,
            Defense
        }

        public string CreatureName;

        public int Value; // bidirectional

        public Argument WhatToQuery;

        public Query(string creatureName, Argument whatToQuery, int value)
        {
            CreatureName = creatureName ?? throw new ArgumentNullException(nameof(creatureName));
            WhatToQuery = whatToQuery;
            Value = value;
        }
    }
}