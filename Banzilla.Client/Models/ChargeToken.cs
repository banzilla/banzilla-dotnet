﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
    public class ChargeToken
    {
        /// <summary>
        /// Object with Order Definition
        /// </summary>
        [Required, ValidateObject]
        public Order Order { get; set; }
        /// <summary>
        /// Encrypted Card
        /// </summary>
        [Required]
        public string Token { get; set; }
        /// <summary>
        /// Method: Token
        /// </summary>
        public string Method => "token";
        /// <summary>
        ///  Description of charge
        /// </summary>
        [Required]
        public string Description { get; set; }
        }
}
