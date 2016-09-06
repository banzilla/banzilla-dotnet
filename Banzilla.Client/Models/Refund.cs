using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
   public class Refund
    {
        [Required]
        public string TransactionId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public eCurrency eCurrency { get; set; }
        public string Currency => eCurrency.ToString();
        [Required]
        public string Reason { get; set; }
    }
}
