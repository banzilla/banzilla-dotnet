using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
    /// <summary>
    /// Object used to generate a new charge with a Credit/Debit Card
    /// </summary>
    public class ChargeCard
    {
        /// <summary>
        ///  Static.Method used for the operation. Default:card
        /// </summary>
        public string Method => "card";
        /// <summary>
        ///  Required.Description of charge. This would appear in the transaction of  customer.
        /// </summary>
        [Required]
        public string Description { get; set; }
        /// <summary>
        ///  Required.Type of Card used by customer.
        /// </summary>
        [Required]
        public eCardGateway eGateway { get; set; }
        /// <summary>
        ///  Required.Definition of Gateway selected.
        /// </summary>
        public string Gateway => eGateway!= eCardGateway.amex ? "prosa" : eGateway.ToString();
        /// <summary>
        /// Required.Summary of the charge.
        /// </summary>
        [Required, ValidateObject]
        public Order Order { get; set; }
        /// <summary>
        /// Required.Card object. Contains all info from card.
        /// </summary>
        [Required, ValidateObject]
        public Card Card { get; set; }
        /// <summary>
        /// Required.Customer info.
        /// </summary>
        [Required, ValidateObject]
        public Customer Customer { get; set; }
        /// <summary>
        /// Optional. Shipping info.
        /// </summary>
        public Shipping Shipping { get; set; }
        /// <summary>
        /// Optional.Detailed list of items.
        /// </summary>
        public List<Item> Items { get; set; }
    }
}
