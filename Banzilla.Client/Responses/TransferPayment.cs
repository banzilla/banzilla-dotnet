using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Responses
{
  public  class TransferPayment
    {
      public string Clabe { get; set; }
      public DateTime DueDate { get; set; }
      public string Reference { get; set; }
      public string Bank { get; set; }
      public string UrlDocument { get; set; }

    }
}
