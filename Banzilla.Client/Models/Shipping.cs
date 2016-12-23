using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
    public class Shipping
    {
        /// <summary>
        /// Name of receiver
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// MiddleName of receiver
        /// </summary>
        [Required]
        public string MiddleName { get; set; }
        /// <summary>
        /// LastName of receiver
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email of receiver
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        /// <summary>
        ///  [Optional] Phonenumber of receiver
        /// </summary>
        [Phone]
        public string Phone { get; set; }
        /// <summary>
        /// [Optional] Shipping Address
        /// </summary>
        [Required, ValidateObject]
        public Address Address { get; set; }
        /// <summary>
        /// [Optional] Mobile of receiver
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// [Optional] Shipping Method
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// [Optional] Reference for shipping address
        /// </summary>
        public string Reference { get; set; }
        /// <summary>
        /// [Optional] Complementary comments
        /// </summary>
        public string Comments { get; set; }

    }
}
