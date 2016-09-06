using System;
using System.Net;
using Banzilla.Client.Models;
using Banzilla.Client.Responses;
using Banzilla.Client.Utils;
using RestSharp;
using RestSharp.Authenticators;

namespace Banzilla.Client.Controller
{
    public class Charge: ControllerBase
    {
      
        /// <summary>
        /// Use for execute new charge
        /// </summary>
        public Charge(string apiKey, string secretKey, bool sandBox) 
            : base(apiKey, secretKey, sandBox)
        {
        }

        /// <summary>
        /// Execute new charge with card data
        /// </summary>
        /// <param name="charge">Charge Card Object</param>
        /// <returns>Confirmation of the charge</returns>
        public dynamic Execute(ChargeCard charge)
        {
           return ApiRequest("charge/", charge, Method.POST, typeof(ChargeCardResponse));
        }

        /// <summary>
        /// Execute new charge with Token (encrypted Card)
        /// </summary>
        /// <param name="token">Charge Token Object</param>
        /// <returns>Confirmation of the charge</returns>
        public dynamic Execute(ChargeToken token)
        {
            return ApiRequest("charge/", token, Method.POST, typeof(ChargeTokenResponse));
        }
        /// <summary>
        /// Execute new Charge with Store-Method
        /// </summary>
        /// <param name="store">Charge Store Object</param>
        /// <returns>Confirmation of the receipt, the charge allways wait for confirmation from the store</returns>
        public dynamic Execute(ChargeStore store)
        {
            return ApiRequest("charge/", store, Method.POST,  typeof(ChargeStoreResponse));
        }

        /// <summary>
        /// Refund Request
        /// </summary>
        /// <param name="refund"></param>
        /// <returns>Confirmation of receipt, the refund allways wait for confirmation from the Banzilla Admin Team</returns>
        public dynamic Execute(Refund refund)
        {
             return ApiRequest("refund/", refund, Method.POST, typeof(RefundResponse));
        }


       
    }
}