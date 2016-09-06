﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
   public  class RefundPayment
    {
        [Required]
        public string Authorization { get; set; }
        [Required]
        public decimal Amount { get; set; }

    }
}
