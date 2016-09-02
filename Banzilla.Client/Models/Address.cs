using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
    public class Address
    {
        /// <summary>
        /// Name of street.
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Exterior number of Address
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// (Optional)Internal number of Address
        /// </summary>
        public string Apartment { get; set; }
        /// <summary>
        /// Name of City
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// ISO Country Code
        /// Ex. "MEX" for Mexico
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// ISO State Code (2 positions)
        /// Ex. PL for Puebla
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Postal code
        /// </summary>
        public string ZipCode { get; set; }
    }
}
