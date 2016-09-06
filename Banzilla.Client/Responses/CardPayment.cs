using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
   public class CardPayment
    {

       public string Authorization { get; set; }
       public string BrandCard { get; set; }
       public string CardNumber { get; set; }
       public string Issuer { get; set; }
       public string TypeCard { get; set; }

    }
}
