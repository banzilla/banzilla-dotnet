using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
   public class Refund
    {
       public string TransactionId { get; set; }
       public decimal Amount { get; set; }
       public string Currency { get; set; }
       public string Reason { get; set; }
    }
}
