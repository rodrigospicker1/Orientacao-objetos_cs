using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Plan : Base{

        public string Name { get; private set; }

        public decimal Price { get; private set; }
    }
}