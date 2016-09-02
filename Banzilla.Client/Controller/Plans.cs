using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Responses;
using RestSharp;

namespace Banzilla.Client.Controller
{
    public class Plans : ControllerBase
    {
     
        public Plans(string apiKey, string secretKey, bool sandBox) : base(apiKey, secretKey, sandBox)
        {
         
        }

        public dynamic Execute(Plans plan)
        {
            return ApiRequest("plans", plan, Method.POST, typeof(PlanResponse));
        }

        public dynamic Search(string idPlan)
        {
            return ApiRequest("plans/" + idPlan, null, Method.GET, typeof(PlanResponse));
        }

        public dynamic List(int page, int size)
        {
            return ApiRequest("plans", new {page, size}, Method.GET, typeof(List<PlanResponse>));
        }

        public dynamic Delete(string idPlan)
        {
            return ApiRequest("plans/" + idPlan, null, Method.DELETE, typeof(string));
        }

        public dynamic Deactivate(string idPlan)
        {
            return ApiRequest("plans/" + idPlan, null, Method.PUT, typeof(string));
        }
    }
}
