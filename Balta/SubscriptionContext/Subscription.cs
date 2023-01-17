using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Subscription : Base{

        public Plan Plan { get; private set; }

        public DateTime? EndDate { get; private set; }

        public bool IsInactive => EndDate <= DateTime.Now;
        
    }
}