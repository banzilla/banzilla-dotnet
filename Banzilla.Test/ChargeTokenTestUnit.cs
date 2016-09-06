using System;
using Banzilla.Client;
using Banzilla.Client.Models;
using Banzilla.Client.Response;
using Banzilla.Client.Responses;
using Banzilla.Client.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banzilla.Test
{
    [TestClass]
    public class ChargeTokenTestUnit
    {
        private APIRequest req;
        public ChargeTokenTestUnit()
        {
            req = new APIRequest("BZS-1SRS-VNBi3F", "A24R-2DRV-K3J2X", true); //Sandbox
        }

        [TestMethod]
        public  void ChargeTokenTest_MustReturnDenied()
        {
            var result = req.Charge.Execute(new ChargeToken()
            {
                Token = "Bz7TkZ9o2bz8xOdgjv", //Denied
                Description = "Prueba de Cargo con Token",
                Order = new Order()
                {
                    Reference = "02/09/16",
                    Amount = 100,
                    eCurrency = eCurrency.MXN
                }
            });


            Type a = result.GetType();
            var b = new Error();
            Assert.IsFalse(result.GetType() == b.GetType());

            Assert.IsTrue(((ChargeTokenResponse)result).Status.ToLower() == "denied");

        }


        [TestMethod]
        public void ChargeTokenTest_MustReturnError()
        {
            var result = req.Charge.Execute(new ChargeToken()
            {
                Token = "Bz7TkZ9o2bz8xOdgjv", //Denied
                Description = "Prueba de Cargo con Token"
               
            });

            Type a = result.GetType();
            var b = new Error();
            Assert.IsTrue(result.GetType() == b.GetType());

        }


        [TestMethod]
        public void ChargeTokenTest_MustReturnOk()
        {
            var result = req.Charge.Execute(new ChargeToken()
            {
                Token = "BzesbCGsHKbvnFOBwe", //Denied
                Description = "Prueba de Cargo con Token",
                Order = new Order()
                {
                    Reference = "02/09/16",
                    Amount = 100,
                    eCurrency = eCurrency.MXN
                }
            });

            Type a = result.GetType();
            var b = new Error();
            Assert.IsFalse(result.GetType() == b.GetType());

            Assert.IsFalse(((ChargeTokenResponse)result).Status.ToLower() == "denied");

            Assert.IsTrue(((ChargeTokenResponse)result).Status.ToLower() == "complete");

        }

    }
}
