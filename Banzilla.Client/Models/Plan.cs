using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
    public class Plan
    {
        [Required]
        public string PlanName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int Frequency { get; set; }
        [Required]
        public int RepeatEvery { get; set; }
        [Required]
        public int MaxAttempts { get; set; }
        [Required]
        public int PlanDuration { get; set; }

    }
}
