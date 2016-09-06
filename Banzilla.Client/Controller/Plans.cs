using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Models;
using Banzilla.Client.Response;
using Banzilla.Client.Responses;
using Banzilla.Client.Utils;
using RestSharp;

namespace Banzilla.Client.Controller
{
    public class Plans : ControllerBase
    {
     
        public Plans(string apiKey, string secretKey, bool sandBox) : base(apiKey, secretKey, sandBox)
        {
         
        }

        public dynamic Create(Plan plan)
        {
              return ApiRequest("plans", plan, Method.POST, typeof(PlanResponse));
        }

        public dynamic Search(string planId)
        {
            if (string.IsNullOrEmpty(planId))
                return new Error
                {
                    Description = "Must add a valid PlanId .",
                    Category = "Request"
                };


            return ApiRequest("plans/" + planId, null, Method.GET, typeof(PlanResponse));
        }

        public dynamic List(ListRequest request)
        {
            return ApiRequest("plans", request, Method.GET, typeof(GenericList<PlanResponse>));
        }

        public dynamic Delete(string planId)
        {
            if (string.IsNullOrEmpty(planId))
                return new Error
                {
                    Description = "Must add a valid PlanId .",
                    Category = "Request"
                };
            return ApiRequest("plans/" + planId, null, Method.DELETE, typeof(string));
        }

        public dynamic Inactivate(string planId)
        {
            if (string.IsNullOrEmpty(planId))
                return new Error
                {
                    Description = "Must add a valid PlanId",
                    Category = "Request"
                };


            return ApiRequest("plans/" + planId, null, Method.PUT, typeof(string));
        }
    }
}
