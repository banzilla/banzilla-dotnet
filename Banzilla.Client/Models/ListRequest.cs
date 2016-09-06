using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
    public class ListRequest
    {
        [Required]
       public int page { get; set; }
        [Required]
        public int size { get; set; }

    }
}
