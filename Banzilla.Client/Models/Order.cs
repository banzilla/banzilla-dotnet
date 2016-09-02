using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
    public class Order
    {
        public string Reference { get; set; }
        public decimal Amount { get; set; }
        public eCurrency eCurrency { get; set; }
        public string Currency => eCurrency.ToString();
    }
}
