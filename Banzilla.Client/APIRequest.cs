using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Banzilla.Client.Controller;
using Banzilla.Client.Models;
using RestSharp;
using RestSharp.Authenticators;

namespace Banzilla.Client
{
    public class APIRequest
    {
        private readonly string _apiKey;
        private readonly string _secretKey;
        private bool _sandBox;
        public Charge Charge { get; }
        public Cards Cards { get; }
        public BlackList BlackList { get; }
        public Plans Plans { get; }
        public Subscriptions Subscriptions { get; }
        public WebHooks WebHooks { get; }

        /// <param name="apiKey">Apikey assigned to your commerce. You can find it in Panel.banzilla.com</param>
        /// <param name="secretKey">Secret Key assigned to your commerce. You can find it in Panel.banzilla.com</param>
        /// <param name="sandBox">true if you want simulate the charge.</param>
        public APIRequest(string apiKey, string secretKey, bool sandBox)
        {
            _apiKey = apiKey;
            _secretKey = secretKey;
            _sandBox = sandBox;

            Charge = new Charge(apiKey,secretKey,sandBox);
            Cards=new Cards(apiKey,secretKey,sandBox);
            BlackList=new BlackList(apiKey,secretKey,sandBox);
            Plans=new Plans(apiKey,secretKey,sandBox);
            Subscriptions=new Subscriptions(apiKey,secretKey,sandBox);
            WebHooks=new WebHooks(apiKey,secretKey,sandBox);
        }

        
    }
}
