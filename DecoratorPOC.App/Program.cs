using DecoratorPOC.Core.Models;
using DecoratorPOC.Core.Models.Decorators;
using System;

namespace DecoratorPOC.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallComponent = new SmallComponent();
            var largeComponent = new LargeComponent();

            var largeAlphaComponent = new AlphaDecorator(largeComponent);
            var largeAlphaBetaComponent = new BetaDecorator(largeAlphaComponent);

            var largeBetaComponent = new BetaDecorator(largeComponent);
            var largeBetaBetaComponent = new BetaDecorator(largeBetaComponent);

            var smallAlphaComponent = new AlphaDecorator(smallComponent);
            var smallAlphaAlphaComponent = new AlphaDecorator(smallAlphaComponent);

            Console.WriteLine($"Description(L): {largeComponent.GetDescription()}, Cost: {largeComponent.GetCost()}");

            Console.WriteLine($"Description(L/A): {largeAlphaComponent.GetDescription()}, Cost: {largeAlphaComponent.GetCost()}");
            Console.WriteLine($"Description(L/A/B): {largeAlphaBetaComponent.GetDescription()}, Cost: {largeAlphaBetaComponent.GetCost()}");

            Console.WriteLine($"Description(L/B): {largeBetaComponent.GetDescription()}, Cost: {largeBetaComponent.GetCost()}");
            Console.WriteLine($"Description(L/B/B): {largeBetaBetaComponent.GetDescription()}, Cost: {largeBetaBetaComponent.GetCost()}");

            Console.WriteLine($"Description(S/A): {smallAlphaComponent.GetDescription()}, Cost: {smallAlphaComponent.GetCost()}");
            Console.WriteLine($"Description(S/A/A): {smallAlphaAlphaComponent.GetDescription()}, Cost: {smallAlphaAlphaComponent.GetCost()}");

            Console.Read();
        }
    }
}
