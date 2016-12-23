using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Banzilla.Client.Models
{
    public class Address
    {
        /// <summary>
        /// Name of street.
        /// </summary>
        [Required]
        public string Street { get; set; }
        /// <summary>
        /// Exterior number of Address
        /// </summary>
        [Required]
        public string Number { get; set; }
        /// <summary>
        /// (Optional)Internal number of Address
        /// </summary>
        public string Apartment { get; set; }
        /// <summary>
        /// Name of City
        /// </summary>
        [Required]
        public string City { get; set; }
        /// <summary>
        /// ISO Country Code
        /// Ex. "MEX" for Mexico
        /// </summary>
        [Required]
        public string Country { get; set; }
        /// <summary>
        /// ISO State Code (2 positions)
        /// Ex. PL for Puebla
        /// </summary>
        [Required]
        public string State { get; set; }
        /// <summary>
        /// Postal code
        /// </summary>
        [Required]
        [MinLength(5)]
        public string ZipCode { get; set; }
    }
}
