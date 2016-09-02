using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
   public class WebHook
    {
       public eMethods eMethod { get; set; }
       public string Method => eMethod.ToString();
       public string Event { get; set; }
       public string Url { get; set; }
    }
}
