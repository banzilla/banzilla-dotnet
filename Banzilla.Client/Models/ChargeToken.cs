using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
    public class ChargeToken
    {
        /// <summary>
        /// Object with Order Definition
        /// </summary>
        public Order Order { get; set; }
        /// <summary>
        /// Encrypted Card
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// Method: Token
        /// </summary>
        public string Method => "token";
        /// <summary>
        ///  Description of the charge
        /// </summary>
        public string Description { get; set; }
        }
}
