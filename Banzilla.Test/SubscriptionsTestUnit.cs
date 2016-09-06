using System;
using Banzilla.Client;
using Banzilla.Client.Models;
using Banzilla.Client.Response;
using Banzilla.Client.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banzilla.Test
{
    [TestClass]
    public class SubscriptionsTestUnit
    {
        private APIRequest req;
        public SubscriptionsTestUnit()
        {
            req = new APIRequest("BZS-1SRS-VNBi3F", "A24R-2DRV-K3J2X", true); //Sandbox
        }
        [TestMethod]
        public void SubscriptionCreateCard_MustReturnOk()
        {
            var address = new Address()
            {
                Number = "13",
                State = "CX",
                City = "Puebla",
                Street = "Desconocida",
                ZipCode = "73310",
                Country = "MEX",
                Apartment = "123"
            };

            var result = req.Subscriptions.Create(new CardSubscription()
            {
                Card = new Card()
                {
                    Address = address,
                    CardNumber = "341673881213039",
                    SecurityCode = "6168",
                    HolderName = "Arturo Perea",
                    ExpYear = "17",
                    ExpMonth = "10"
                },
                Phone = "5511703731",
                Email = "aperea@holdingleos.com",
                OrderId = "123",
                IdPlan = "V5WQE9PDbwxfx9U4",
                StartDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"),
                Subscriber = "Arturo Perea"
            });

            Type a = result.GetType();
            var b = new Error();

            Assert.IsFalse(result.GetType() == b.GetType());

           
            Assert.IsTrue(!string.IsNullOrEmpty(((SubscriptionResponse)result).IdSubscription));
        }


        [TestMethod]
        public void SubscriptionCreateCard_MustReturnError()
        {
            var address = new Address()
            {
                Number = "13",
                State = "CX",
                City = "Puebla",
                Street = "Desconocida",
                ZipCode = "73310",
                Country = "MEX",
                Apartment = "123"
            };

            var result = req.Subscriptions.Create(new CardSubscription()
            {
                Card = new Card()
                {
                    Address = address,
                    CardNumber = "34167388121",
                    SecurityCode = "6168",
                    HolderName = "Arturo Perea",
                    ExpYear = "17",
                    ExpMonth = "10"
                },
                Phone = "5511703731",
                Email = "aperea@holdingleos.com",
                OrderId = "123",
                IdPlan = "V5WQE9PDbwxfx9U4",
                StartDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"),
                Subscriber = "Arturo Perea"
            });

            Type a = result.GetType();
            var b = new Error();

            Assert.IsTrue(result.GetType() == b.GetType());


        }


        [TestMethod]
        public void SubscriptionCreatedToken_MustReturError()
        {
            var result = req.Subscriptions.Create(new TokenSubscription()
            {
                Phone = "5527251902",
                Token = "552725192",
                Email = "aperea@holdingleos.com",
                StartDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"),
                Subscriber = "Arturo Perea",
                PlanId = "V5WQE9PDbwxfx9U4",
                OrderId = "234"
            });

            var b = new Error();
            bool validateErrorType = result.GetType() == b.GetType();
            //If error but
            Assert.IsTrue(validateErrorType);
        }

        [TestMethod]
        public void SubscriptionSearch_MustReturnOk()
        {
            var result = req.Subscriptions.Search("kyEN6WJ9qe622BeJ");

            Type a = result.GetType();
            var b = new Error();
            Assert.IsFalse(result.GetType() == b.GetType());


            Assert.IsTrue(!string.IsNullOrEmpty(((FullSubscriptionResponse)result).Subscription.IdSubscription));

        }

        //[TestMethod]
        //public void SubscriptionDeactivate_MustReturnOk()
        //{
        //    var result = req.Subscriptions.Deactivate("kyEN6WJ9qe622BeJ")

        //    Type a = result.GetType();
        //    var b = new Error();
        //    Assert.IsFalse(result.GetType() == b.GetType());


        //    Assert.IsTrue(!string.IsNullOrEmpty(((FullSubscriptionResponse)result).Subscription.IdSubscription));

        //}

        [TestMethod]
        public void SubscriptionList_MustReturnOk()
        {
            var result = req.Subscriptions.List();

            Type a = result.GetType();
            var b = new Error();
            Assert.IsFalse(result.GetType() == b.GetType());


            Assert.IsTrue(((GenericList<FullSubscriptionResponse>)result).TotalCount>=0);

        }
    }


}
