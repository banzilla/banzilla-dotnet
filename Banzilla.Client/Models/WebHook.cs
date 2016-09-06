using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Utils;

namespace Banzilla.Client.Models
{
    public class WebHook
    {
        [Required]
        public eMethods eMethod { get; set; }

        public string Method => eMethod.ToString();

        [Required]
        public string Event { get; set; }

        [Required]
        public string Url { get; set; }
    }
}
