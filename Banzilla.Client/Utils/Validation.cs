using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Response;

namespace Banzilla.Client.Utils
{
    public class Validation
    {
        public static Error Validate(object instance)
        {
       

            var context = new ValidationContext(instance, null, null);
            var results = new List<ValidationResult>();

            var result= Validator.TryValidateObject(instance, context, results, true);
            if (!result)
            {
                var errorDetails = new List<string>();
                results.ForEach(c=> errorDetails.Add(c.ErrorMessage));
                
                return new Error
                {
                    Description = "Must fix errors",
                    Category = "Request",
                    ErrorCode = "Error",
                    Status = "",
                    IdRequest = "",
                    Details = errorDetails
                };
            }
            return null;
        }
    }
}
