using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Models
{
    public class GenericList<T>  where T : class
    {
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public IList<T> List{ get; set; }
    }
}
