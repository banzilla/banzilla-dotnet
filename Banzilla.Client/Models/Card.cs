using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
   public  class Card
    {
        /// <summary>
        /// Name of Card owner
        /// </summary>
        public string HolderName { get; set; }
        /// <summary>
        /// Card Number without spaces and dashes
        /// </summary>
        public string CardNumber { get; set; }
        /// <summary>
        /// Card CVV
        /// </summary>
        public string SecurityCode { get; set; }
        /// <summary>
        /// Card Expiration Month
        /// 2 Digits format. Ex. 02 
        /// </summary>
        public string ExpMonth { get; set; }
        /// <summary>
        /// Card Expiration Year
        /// 2 Digits format. Ex: 17
        /// </summary>
        public string ExpYear { get; set; }
        /// <summary>
        /// Card´s holdername billing address.
        /// </summary>
        public Address Address { get; set; }
    }
}
