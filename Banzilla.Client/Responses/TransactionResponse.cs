using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Models;

namespace Banzilla.Client.Responses
{
    public class TransactionResponse
    {
        public string OperativeStatus { get; set; }
        public string Currency { get; set; }
        public int Exchange { get; set; }
        public string IdTransaction { get; set; }
        public string OrderId { get; set; }
        public string Description { get; set; }
        public string Created { get; set; }
        public decimal Amount { get; set; }
        public string MethodType { get; set; }
        public string Terminal { get; set; }
        public Card Card { get; set; }
        public Customer Customer { get; set; }
        public Shipping Shipping { get; set; }
        public List<Item> Products { get; set; }


    }
}
