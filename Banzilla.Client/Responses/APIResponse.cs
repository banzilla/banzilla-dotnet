using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Response
{
    public class APIResponse
    {
        public string ResultCode { get; set; }

        public Error Error { get; set; }
        public Success Success { get; set; }
    }
}
