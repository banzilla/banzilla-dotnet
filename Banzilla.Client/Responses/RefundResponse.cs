﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Models;

namespace Banzilla.Client.Responses
{
   public class RefundResponse
    {
        public string IdTransaction { get; set; }
        public string CreationDate { get; set; }
        public string RequestId { get; set; }
        public string Method { get; set; }
        public string Gateway { get; set; }
        public string Status { get; set; }
       public RefundPayment RefundPayment { get; set; }

    }
}
