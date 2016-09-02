
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Models;

namespace Banzilla.Client.Responses
{
    public class TokenResponse
    {
        public string Token { get; set; }
        public bool Active { get; set; }
        public string HolderName { get; set; }
        public string CardNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName{ get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string BrandCard { get; set; }
        public string Issuer { get; set; }
        public string Bin { get; set; }
        public string Created { get; set; }
        public string Last4 { get; set; }

        public Address Address { get; set; }

    }
}
