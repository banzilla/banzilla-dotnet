using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using Banzilla.Client.Models;
using Banzilla.Client.Response;
using Banzilla.Client.Responses;
using Banzilla.Client.Utils;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Web;

namespace Banzilla.Client.Controller
{
    public class ControllerBase
    {
        private readonly string _apiKey;
        private readonly string _secretKey;
        public string lastResponse;

        private bool _sandBox;

        public ControllerBase(string apiKey, string secretKey, bool sandBox)
        {
            _apiKey = apiKey;
            _secretKey = secretKey;
            _sandBox = sandBox;
        }

        internal dynamic ApiRequest(string path, object parameters, Method httpMethod, Type responseType)
        {
            if (parameters != null)
            {

                var error = Validation.Validate(parameters);
                if (error != null)
                    return error;
            }

                var host = $"{GetRequestUrl(_sandBox)}";
                var user = _apiKey;
                var password = _secretKey;

                var client = new RestClient(host) {Authenticator = new HttpBasicAuthenticator(user, password)};
                var request = new RestRequest(path, httpMethod);
                string json = JsonConvert.SerializeObject(parameters);
                if (parameters != null)
                    request.AddJsonBody(parameters);

                var response = client.Execute(request);
                lastResponse = response.Content;
                if (!Enum.IsDefined(typeof(HttpStatusCode), response.StatusCode))
                {
                    throw new HttpException((int)response.StatusCode, response.ErrorMessage);
                }
                if (response.StatusCode != (HttpStatusCode) HttpStatusCode.OK)
                {
                    if(string.IsNullOrEmpty(response.Content)) throw new HttpException((int)response.StatusCode, response.ErrorMessage);

                    return JsonConvert.DeserializeObject(response.Content, typeof(Error));
                }

                var result = JsonConvert.DeserializeObject(response.Content, responseType);

                return result;
        
        }

        private string GetRequestUrl(bool sandbox)
        {

            var key = ConfigurationManager.AppSettings.AllKeys.FirstOrDefault(k => k == "banzilla:local");
            if (string.IsNullOrWhiteSpace(key) || ConfigurationManager.AppSettings["banzilla:local"].ToLower() == "false")
                return sandbox ? "https://sandbox.banzilla.com/v1/" : "https://api.banzilla.com/v1/";
            
            return sandbox ? "http://10.0.1.199/v1/" : "http://10.0.1.197/v1/";
        }

    }
}