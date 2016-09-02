using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Models;

namespace Banzilla.Client.Responses
{
    public class SubscriptionResponses
    {
        public string IdSubscription { get; set; }
        public string Subscriber { get; set; }
        public string CardNumber { get; set; }
        public string Token { get; set; }
        public string IdPlan { get; set; }
        public string PlanName { get; set; }
        public decimal Amount { get; set; }
        public int Frecuency { get; set; }
        public int RepeatEvery { get; set; }
        public int PlanDuration { get; set; }
        public int MaxAttempts { get; set; }
        public string NextPayment { get; set; }


    }

    public class FullSubscriptionResponse
    {
        public Card Card { get; set; }
        public Plan Plan { get; set; }
        public SubscriptionResponses Subscription { get; set; }
    }
}
