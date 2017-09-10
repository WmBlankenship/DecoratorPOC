using DecoratorPOC.Core.Models;
using DecoratorPOC.Core.Models.Decorators;
using System;

namespace DecoratorPOC.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new LargePizza();
            var pepperoniPizza = new PepperoniPizzaDecorator(pizza);

            var sausagePizza = new SausagePizzaDecorator(pizza);
            var sausageAndPepperoniPizza = new SausagePizzaDecorator(pepperoniPizza);

            var dblSausagePizza = new SausagePizzaDecorator(sausagePizza);

            Console.WriteLine($"Description: {pizza.GetDescription()}, Cost: {pizza.GetCost()}");
            Console.WriteLine($"Description w/Pep: {pepperoniPizza.GetDescription()}, Cost: {pepperoniPizza.GetCost()}");
            Console.WriteLine($"Description w/Sau: {sausagePizza.GetDescription()}, Cost: {sausagePizza.GetCost()}");
            Console.WriteLine($"Description w/Pep & Sau: {sausageAndPepperoniPizza.GetDescription()}, Cost: {sausageAndPepperoniPizza.GetCost()}");
            Console.WriteLine($"Description w/Dbl Sau: {dblSausagePizza.GetDescription()}, Cost: {dblSausagePizza.GetCost()}");

            Console.Read();
        }
    }
}
