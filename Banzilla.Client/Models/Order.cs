using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
    public class Order
    {
        [Required]
        public string Reference { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public eCurrency eCurrency { get; set; }

        public string Website { get; set; }

        public string Currency => eCurrency.ToString();
    }
}
