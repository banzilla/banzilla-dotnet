using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
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
        /// <summary>
        /// Max attempts for try one charge.
        /// </summary>
        [Required]
       public int MaxAttempts { get; set; }
        /// <summary>
        /// [Optional]How many charges will have the subscription.
        /// if duration=null, plan will have unlimited charges until cancelation
        /// </summary>
        public int PlanDuration { get; set; }

    }
}
