using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Models;
using Banzilla.Client.Response;
using Banzilla.Client.Responses;
using Banzilla.Client.Utils;
using RestSharp;

namespace Banzilla.Client.Controller
{
    public class Subscriptions : ControllerBase
    {
       
        public Subscriptions(string apiKey, string secretKey, bool sandBox) : base(apiKey, secretKey, sandBox)
        {
        }

        public dynamic Create(CardSubscription subscription)
        {
               return ApiRequest("subscription", subscription, Method.POST, typeof(SubscriptionResponse));
        }

        public dynamic Create(TokenSubscription subscription)
        {
              return ApiRequest("subscription", subscription, Method.POST, typeof(SubscriptionResponse));
        }

        public dynamic Search(string subscriptionId)
        {
            if (string.IsNullOrEmpty(subscriptionId))
                return new Error
                {
                    Description = "Must add a valid subscriptionId",
                    Category = "Request"
                };

            return ApiRequest("subscription/" + subscriptionId, null, Method.GET, typeof(FullSubscriptionResponse));
        }

        public dynamic Inactivate(string subscriptionId)
        {
            if (string.IsNullOrEmpty(subscriptionId))
                return new Error
                {
                    Description = "Must add a valid subscriptionId",
                    Category = "Request"
                };
            return ApiRequest("subscription/" + subscriptionId, null, Method.DELETE, typeof(string));
        }

        public dynamic List()
        {
            return ApiRequest("subscription/" , null, Method.GET, typeof(GenericList<FullSubscriptionResponse>));
        }
    }
}
