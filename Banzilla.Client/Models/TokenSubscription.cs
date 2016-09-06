using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
    public class TokenSubscription
    {
        [Required]
        public string PlanId { get; set; }
        [Required]
        public string Subscriber { get; set; }
        [Required]
        public string StartDate { get; set; }
        [Required]
        public string OrderId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string Token { get; set; }

    }
}
