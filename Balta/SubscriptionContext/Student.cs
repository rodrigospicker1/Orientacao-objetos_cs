using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base{

        public Student(Parameters)
        {
            Subscriptions = new List<Subscription>();
        }

        public User User { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public IList<Subscription> Subscriptions { get; set; } 

        public void CreateSubscription(Subscription subscription){`
        
            if(IsPremium){

                AddNotification(new Notification("Premium", "O aluno ja tem assinatura"));
                return;

            }

            Subscriptions.Add(Subscription);

        }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}