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
        /// <param name="CardNumber">Card number</param>
        /// <param name="Reason">Reason to identify why you send this card to Blacklist</param>
        /// <returns>"ok" or Error Object</returns>
        public dynamic Execute(string CardNumber, string Reason)
        {
            return ApiRequest("cards/blacklist", new {CardNumber, Reason}, Method.POST, typeof(string) );
        }
        /// <summary>
        /// Remove Card from Blacklist
        /// </summary>
        /// <param name="cardNumber">Card Number</param>
        /// <returns>"ok" or Error Object</returns>
        public dynamic Delete(string cardNumber)
        {
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
