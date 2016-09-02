using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Responses
{
    public class BlackListResponse
    {
        public string Created { get; set; }
        public string Global { get; set; }
        public string Card { get; set; }
        public string Reason { get; set; }

    }
}
