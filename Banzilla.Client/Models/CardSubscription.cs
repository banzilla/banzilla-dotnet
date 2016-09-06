using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
   public class CardSubscription
    {
        /// <summary>
        /// Id of Plan
        /// </summary>
        [Required]
        public string IdPlan { get; set; }
        /// <summary>
        /// Name of Subscriber
        /// </summary>
        [Required]
        public string Subscriber { get; set; }
        /// <summary>
        /// Subscription Start date 
        /// </summary>
        [Required]
        public string StartDate { get; set; }
        /// <summary>
        /// Reference number
        /// </summary>
        [Required]
        public string OrderId { get; set; }
        /// <summary>
        /// Email of Subscriber
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        /// <summary>
        /// Phone of Subscriber
        /// </summary>
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]{10}$")]
        public string Phone { get; set; }
        /// <summary>
        /// Card used for Generate subscription
        /// </summary>
        [Required, ValidateObject]
        public Card Card { get; set; }
    }
}
