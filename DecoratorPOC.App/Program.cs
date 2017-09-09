using DecoratorPOC.Core.Models;
using System;

namespace DecoratorPOC.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new LargePizza();
            var pepperoniPizza = new PepperoniPizzaDecorator(pizza);

            Console.WriteLine($"Description: {pizza.GetDescription()}, Cost: {pizza.GetCost()}");
            Console.WriteLine($"Description w/Pep: {pepperoniPizza.GetDescription()}, Cost: {pepperoniPizza.GetCost()}");
            Console.Read();
        }
    }
}
