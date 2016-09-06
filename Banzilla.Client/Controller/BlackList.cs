using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Models;
using Banzilla.Client.Response;
using Banzilla.Client.Responses;
using RestSharp;

namespace Banzilla.Client.Controller
{
    public class BlackList : ControllerBase
    {
       /// <summary>
       /// Use for create, delete or read cards from blacklist
       /// </summary>
        public BlackList(string apiKey, string secretKey, bool sandBox) : base(apiKey, secretKey, sandBox)
        {
           
        }

        /// <summary>
        /// Send Card number to blacklist
        /// If card exists in blacklist all charges with this card will be denied.
        /// </summary>
        /// <param name="cardNumber">Card number</param>
        /// <param name="Reason">Reason to identify why you send this card to Blacklist</param>
        /// <returns>"ok" or Error Object</returns>
        public dynamic Execute(string cardNumber, string reason)
        {
            if (string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(reason))
                return new  Error
                {
                    Description = "Must add a valid cardNumber and a Reason.",
                    Category = "Request"
                };
         
            return ApiRequest("cards/blacklist", new {CardNumber = cardNumber, reason }, Method.POST, typeof(string) );
        }
        /// <summary>
        /// Remove Card from Blacklist
        /// </summary>
        /// <param name="cardNumber">Card Number</param>
        /// <returns>"ok" or Error Object</returns>
        public dynamic Delete(string cardNumber)
        {
            if (string.IsNullOrEmpty(cardNumber))
                return new Error
                {
                    Description = "Must add a valid cardNumber.",
                    Category = "Request",
                };
            return ApiRequest("cards/blacklist/" + cardNumber, null, Method.DELETE, typeof(string));
        }
        /// <summary>
        /// All Cards you have in blacklist
        /// </summary>
        /// <returns>List of Blacklist Object</returns>
        public dynamic List()
        {
            return ApiRequest("cards/blacklist", null, Method.GET,typeof(GenericList<BlackListResponse>));
        }
    }
}
