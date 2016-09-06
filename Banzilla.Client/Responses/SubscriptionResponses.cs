using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Models;

namespace Banzilla.Client.Responses
{
    public class SubscriptionResponse
    {
        public string IdSubscription { get; set; }
        public string Subscriber { get; set; }
        public string CardNumber { get; set; }
        public string Token { get; set; }
        public string IdPlan { get; set; }
        public string PlanName { get; set; }
        public decimal Amount { get; set; }
        public int Frequency { get; set; }
        public int RepeatEvery { get; set; }
        public int PlanDuration { get; set; }
        public int MaxAttempts { get; set; }
        public string NextPayment { get; set; }


    }

   
}
