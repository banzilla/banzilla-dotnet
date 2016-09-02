using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
    public class TokenSubscription
    {
        public string PlanId { get; set; }
        public string Subscriber { get; set; }
        public string StartDate { get; set; }
        public string OrderId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Token { get; set; }

    }
}
