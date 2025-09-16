using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayAccessor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console output the fruit with the highest cost

            //Console output the fruit with the longest name

            //Console output all yellow fruits
        }

        record Fruit(string Name, string Color, int Cost);

        static List<Fruit> Fruits = new List<Fruit>
        {
            new Fruit("Apple", "Red", 3),
            new Fruit("Banana", "Yellow", 1),
            new Fruit("Grapes", "Purple", 2),
            new Fruit("Orange", "Orange", 2),
            new Fruit("Mango", "Yellow", 5)
        };
    }
}