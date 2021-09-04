using System;
using System.Collections.Generic;

namespace Patron2
{
    internal class SampleTests
    {
        internal static void Test1()
        {
            var actual = new CoffeBuilder().SetBlackCoffee().WithSugar("Regular").WithMilk(3.2).Build();
            var expected = new Coffee("Black", new List<Milk> { new Milk(3.2) }, new List<Sugar> { new Sugar("Regular") });
            Console.WriteLine($"expected: {expected}");
            Console.WriteLine($"actual: {actual}");

            bool assertAreEqual = expected.ToString() == actual.ToString();
            Console.WriteLine("Test " + (assertAreEqual ? " -------- ok" : " -------------- FAIL"));
        }

        internal static void Test2()
        {
            var actual = new CoffeBuilder().SetAntoccinoCoffee().Build();
            var expected = new Coffee("Americano", new List<Milk> { new Milk(0.0) }, new List<Sugar>());
            Console.WriteLine($"expected: {expected}");
            Console.WriteLine($"actual: {actual}");

            bool assertAreEqual = expected.ToString() == actual.ToString();
            Console.WriteLine("Test " + (assertAreEqual ? " -------- ok" : " -------------- FAIL"));
        }

        internal static void Test3()
        {
            var actual = new CoffeBuilder().SetCubanoCoffee().Build();
            var expected = new Coffee("Cubano", new List<Milk>(), new List<Sugar> { new Sugar("Brown") });
            Console.WriteLine($"expected: {expected}");
            Console.WriteLine($"actual: {actual}");

            bool assertAreEqual = expected.ToString() == actual.ToString();
            Console.WriteLine("Test " + (assertAreEqual ? " -------- ok" : " -------------- FAIL"));
        }
    }
}