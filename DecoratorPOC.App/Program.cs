using DecoratorPOC.Core.Models;
using DecoratorPOC.Core.Models.Decorators;
using System;

namespace DecoratorPOC.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallPizza = new Smallizza();
            var largePizza = new LargePizza();

            var pepperoniPizza = new PepperoniPizzaDecorator(largePizza);
            var sausageAndPepperoniPizza = new SausagePizzaDecorator(pepperoniPizza);

            var sausagePizza = new SausagePizzaDecorator(largePizza);
            var dblSausagePizza = new SausagePizzaDecorator(sausagePizza);

            var smallPepperoniPizza = new PepperoniPizzaDecorator(smallPizza);
            var smallDblPepperoniPizza = new PepperoniPizzaDecorator(smallPepperoniPizza);

            Console.WriteLine($"Description: {largePizza.GetDescription()}, Cost: {largePizza.GetCost()}");

            Console.WriteLine($"Description w/Pep: {pepperoniPizza.GetDescription()}, Cost: {pepperoniPizza.GetCost()}");
            Console.WriteLine($"Description w/Pep & Sau: {sausageAndPepperoniPizza.GetDescription()}, Cost: {sausageAndPepperoniPizza.GetCost()}");

            Console.WriteLine($"Description w/Sau: {sausagePizza.GetDescription()}, Cost: {sausagePizza.GetCost()}");
            Console.WriteLine($"Description w/Dbl Sau: {dblSausagePizza.GetDescription()}, Cost: {dblSausagePizza.GetCost()}");

            Console.WriteLine($"Description sm w/Pep: {smallPepperoniPizza.GetDescription()}, Cost: {smallPepperoniPizza.GetCost()}");
            Console.WriteLine($"Description sm w/Dbl Pep: {smallDblPepperoniPizza.GetDescription()}, Cost: {smallDblPepperoniPizza.GetCost()}");

            Console.Read();
        }
    }
}
