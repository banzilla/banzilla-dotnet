using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
    public class Plan
    {
        public string PlanName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int Frecuency { get; set; }
        public int RepeatEvery { get; set; }
        public int Attempts { get; set; }
        public int PlanDuration { get; set; }

    }
}
