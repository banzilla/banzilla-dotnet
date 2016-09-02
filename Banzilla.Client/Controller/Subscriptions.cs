using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Models;
using Banzilla.Client.Responses;
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
            return ApiRequest("subscription", subscription, Method.POST, typeof(SubscriptionResponses));
        }

        public dynamic Create(TokenSubscription subscription)
        {
            return ApiRequest("subscription", subscription, Method.POST, typeof(SubscriptionResponses));
        }

        public dynamic Search(string subscriptionId)
        {
            return ApiRequest("subscription/" + subscriptionId, null, Method.GET, typeof(FullSubscriptionResponse));
        }

        public dynamic Deactivate(string subscriptionId)
        {
            return ApiRequest("subscription/" + subscriptionId, null, Method.PUT, typeof(string));
        }

        public dynamic List()
        {
            return ApiRequest("subscription/" , null, Method.GET, typeof(string));
        }
    }
}
