using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
    public class ChargeStore
    {
        /// <summary>
        /// Static.Method: Store
        /// </summary>
        public string Method => "store";
        /// <summary>
        /// Required.Store selected by user for payment
        /// </summary>
        [Required]
        public eStoreGateways eGateway { get; set; }
        /// <summary>
        ///  Required.Definition of Gateway selected.
        /// </summary>
        public string Gateway => eGateway.ToString();
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
      

     
  
    }
}
