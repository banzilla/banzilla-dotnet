using System;
using System.Collections.Generic;
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
        public eStoreGateways eGateway { get; set; }
        /// <summary>
        ///  Required.Definition of Gateway selected.
        /// </summary>
        public string Gateway => eGateway.ToString();
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Required.Description of charge
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Required.Object with Order Definition
        /// </summary>
        public Order Order { get; set; }
        /// <summary>
        /// Required.Customer object
        /// </summary>
        public Customer Customer { get; set; }
      

     
  
    }
}
