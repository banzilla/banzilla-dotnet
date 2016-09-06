using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Responses
{
  public   class FullSubscriptionResponse
    {
      public SubscriptionCard Card { get; set; }
      public SubscriptionPlan Plan { get; set; }

        public SubscriptionDetail Subscription { get; set; }

    }

    public class SubscriptionCard
    {
        public string Token { get; set; }
        public string HolderName { get; set; }
        public string CardNumber { get; set; }

    }

    public class SubscriptionPlan
    {
        public string IdPlan { get; set; }
        public bool IsActive { get; set; }
        public string PlanName { get; set; }
        public decimal Amount { get; set; }
        public int Frequency { get; set; }
        public int RepeatEvery { get; set; }
        public int PlanDuration { get; set; }
        public int Attemps { get; set; }

    }

    public class SubscriptionDetail
    {
        public string Email { get; set; }
        public string Created { get; set; }
        public string Begin { get; set; }
        public int Attempts { get; set; }
        public int Payments { get; set; }
        public int RemainingPayments { get; set; }
        public bool Completed { get; set; }
        public bool Active { get; set; }
        public string IdSubscription { get; set; }
        public string Subscriber { get; set; }
        public decimal Amount { get; set; }
        public int Frequency { get; set; }
        public int RepeatEvery { get; set; }
        public int MaxAttempts { get; set; }
        public string NextPayment { get; set; }


    }
}
