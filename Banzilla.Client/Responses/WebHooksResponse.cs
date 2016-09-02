
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Responses
{
    public class WebHooksResponse
    {
        public string IdWebhook { get; set; }
        public string Creation { get; set; }
        public bool Verified  { get; set; }
        public string Url { get; set; }
        public string Method { get; set; }
        public string Event { get; set; }

    }
}
