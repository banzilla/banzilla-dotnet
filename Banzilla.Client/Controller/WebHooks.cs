﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Models;
using Banzilla.Client.Responses;
using RestSharp;

namespace Banzilla.Client.Controller
{
   public class WebHooks : ControllerBase
    {
        public WebHooks(string apiKey, string secretKey, bool sandBox) : base(apiKey, secretKey, sandBox)
        {
        
        }

       public dynamic Execute(WebHook webhook)
       {
            return ApiRequest("webhooks", webhook, Method.POST, typeof(WebHooksResponse));
        }

        public dynamic Search(string webhookId)
        {
            return ApiRequest("webhooks/" + webhookId, null, Method.GET,  typeof(WebHooksResponse));
        }

        public dynamic Delete(string webhookId)
        {
            return ApiRequest("webhooks/" + webhookId, null, Method.DELETE, typeof(string));
        }

        public dynamic List()
        {
            return ApiRequest("webhooks" , null, Method.GET, typeof(WebHooksResponse));
        }
    }
}
