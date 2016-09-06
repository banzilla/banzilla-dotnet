using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
   public  class Card
    {
        /// <summary>
        /// Name of Card owner
        /// </summary>
        [Required]
        public string HolderName { get; set; }
        /// <summary>
        /// Card Number without spaces and dashes
        /// </summary>
        [Required]
        [DataType(DataType.CreditCard)]
        [CreditCard(CreditCardAttribute.CardType.All)]
        public string CardNumber { get; set; }
        /// <summary>
        /// Card CVV
        /// </summary>
        [Required]
        public string SecurityCode { get; set; }
        /// <summary>
        /// Card Expiration Month
        /// 2 Digits format. Ex. 02 
        /// </summary>
        [Required]
        public string ExpMonth { get; set; }
        /// <summary>
        /// Card Expiration Year
        /// 2 Digits format. Ex: 17
        /// </summary>
        [Required]
        public string ExpYear { get; set; }
        /// <summary>
        /// Card´s holdername billing address.
        /// </summary> 
        [Required,ValidateObject]
        public Address Address { get; set; }
    }
}
