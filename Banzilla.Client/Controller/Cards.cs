using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client.Controller;
using Banzilla.Client.Models;
using Banzilla.Client.Response;
using Banzilla.Client.Responses;
using Banzilla.Client.Utils;
using RestSharp;

namespace Banzilla.Client.Controller
{
 
    public class Cards : ControllerBase
    {
  
        /// <summary>
        /// Use for encrypt a new Card (Tokenize)
        /// </summary>
        public Cards(string apiKey, string secretKey, bool sandBox) : base(apiKey, secretKey, sandBox)
        {

        }
        /// <summary>
        /// Encrypt a new Card
        /// </summary>
        /// <param name="token">Token object</param>
        public dynamic Create(Token token)
        {
            return  ApiRequest("cards", token, Method.POST, typeof(TokenResponse));
        }

        /// <summary>
        /// Search an existing token
        /// </summary>
        /// <param name="token">string: Token Id</param>
        public dynamic Search(string token)
        {
            if (string.IsNullOrEmpty(token))
                return new Error
                {
                    Description = "Must add a valid token",
                    Category = "Request"
                };


            return ApiRequest("cards/" + token, null, Method.GET, typeof(TokenResponse));
        }
        /// <summary>
        /// Get all tokens created.
        /// </summary>
        public dynamic List()
        {
            return ApiRequest("cards", null, Method.GET, typeof(GenericList<TokenResponse>));
        }

        /// <summary>
        /// Delete an existing token
        /// When a Token is deleted, you can't activate again at least you create new encrypt.
        /// </summary>
        /// <param name="token">string: Token Id</param>
        public dynamic Delete(string token)
        {
            if (string.IsNullOrEmpty(token))
                return new Error
                {
                    Description = "Must add a valid token",
                    Category = "Request"
                };

            return ApiRequest("cards/" + token, null, Method.DELETE, typeof(string));
        }
        /// <summary>
        /// Inactivate an existing token
        /// </summary>
        /// <param name="token">string: Token id</param>
        public dynamic Inactivate(string token)
        {
            if (string.IsNullOrEmpty(token))
                return new Error
                {
                    Description = "Must add a valid token",
                    Category = "Request"
                };


            return ApiRequest("cards/" + token, null, Method.PUT, typeof(string));
        }
    }

}
