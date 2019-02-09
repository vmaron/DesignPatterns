﻿using System;
using System.Collections.Generic;

namespace Creational.Factories.AbstractFactory
{
    public class HotDrinkMachine
    {
        public enum AvailableDrink // violates open-closed
        {
            Coffee,
            Tea
        }

        private readonly List<Tuple<string, IHotDrinkFactory>> namedFactories =
            new List<Tuple<string, IHotDrinkFactory>>();

        private Dictionary<AvailableDrink, IHotDrinkFactory> factories =
            new Dictionary<AvailableDrink, IHotDrinkFactory>();

        public HotDrinkMachine()
        {
            //foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            //{
            //  var factory = (IHotDrinkFactory) Activator.CreateInstance(
            //    Type.GetType("DotNetDesignPatternDemos.Creational.AbstractFactory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory"));
            //  factories.Add(drink, factory);
            //}

            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                    namedFactories.Add(Tuple.Create(
                        t.Name.Replace("Factory", string.Empty), (IHotDrinkFactory) Activator.CreateInstance(t)));
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks");
            for (var index = 0; index < namedFactories.Count; index++)
            {
                var tuple = namedFactories[index];
                Console.WriteLine($"{index}: {tuple.Item1}");
            }

            while (true)
            {
                string s;
                if ((s = Console.ReadLine()) != null
                    && int.TryParse(s, out var i) // c# 7
                    && i >= 0
                    && i < namedFactories.Count)
                {
                    Console.Write("Specify amount: ");
                    s = Console.ReadLine();
                    if (s != null
                        && int.TryParse(s, out var amount)
                        && amount > 0)
                        return namedFactories[i].Item2.Prepare(amount);
                }

                Console.WriteLine("Incorrect input, try again.");
            }
        }

        //public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        //{
        //  return factories[drink].Prepare(amount);
        //}
    }
}