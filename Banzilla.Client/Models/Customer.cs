using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
    public class Customer
    {
        /// <summary>
        /// Customer Name
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer Middle Name 
        /// </summary>
        [Required]
        public string MiddleName { get; set; }

        /// <summary>
        /// Customer Last Name
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Customer Email
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Customer Addres.
        /// </summary>
        [Required, ValidateObject]
        public Address Address { get; set; }
    }
}
