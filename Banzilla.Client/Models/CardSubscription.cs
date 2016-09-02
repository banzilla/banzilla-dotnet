using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
   public class CardSubscription
    {
        /// <summary>
        /// Id of Plan
        /// </summary>
        public string PlanId { get; set; }
        /// <summary>
        /// Name of Subscriber
        /// </summary>
        public string Subscriber { get; set; }
        /// <summary>
        /// Subscription Start date 
        /// </summary>
        public string StartDate { get; set; }
        /// <summary>
        /// Reference number
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// Email of Subscriber
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Phone of Subscriber
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Card used for Generate subscription
        /// </summary>
        public Card Card { get; set; }
    }
}
