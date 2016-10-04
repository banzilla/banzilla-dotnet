using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
    public class ChargeSpei
    {
        /// <summary>
        /// Static.Method: Store
        /// </summary>
        public string Method => "transfer";
        /// <summary>
        /// Static.Gateway selected by user for payment
        /// </summary>
        [Required]
        public string Gateway => "spei";
        /// <summary>
        /// Required. Due date.
        /// </summary>
        [Required]
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Required.Description of charge
        /// </summary>
        [Required]
        public string Description { get; set; }
        /// <summary>
        /// Required.Object with Order Definition
        /// </summary>
        [Required, ValidateObject]
        public Order Order { get; set; }
        /// <summary>
        /// Required.Customer object
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
