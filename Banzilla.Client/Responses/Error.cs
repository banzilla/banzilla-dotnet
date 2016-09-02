using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Response
{
    public class Error
    {
        public string Category { get; set; }
        public string ErrorCode { get; set; }
        public string Description { get; set; }
        public string IdRequest { get; set; }
        public string Status { get; set; }
        public object Details { get; set; }
    }
}
