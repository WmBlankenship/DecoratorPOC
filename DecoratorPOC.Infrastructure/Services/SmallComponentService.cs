using DecoratorPOC.Core.Models;

namespace DecoratorPOC.Infrastructure.Services
{
    public class SmallComponentService
    {
        public SmallComponent GetSmallComponent()
        {
            return new SmallComponent();
        }
    }
}
