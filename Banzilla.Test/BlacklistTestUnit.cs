using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client;
using Banzilla.Client.Models;
using Banzilla.Client.Response;
using Banzilla.Client.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banzilla.Test
{
    [TestClass]
    public class BlacklistTestUnit
    {
        private APIRequest req;
        public BlacklistTestUnit()
        {
            req = new APIRequest("BZS-1SRS-VNBi3F", "A24R-2DRV-K3J2X", true); //Sandbox
        }


        [TestMethod]
        public void BlackListCreateTest_MustReturnError()
        {
            var result = req.BlackList.Execute("", "");
        

            Type a = result.GetType();
            var b = new Error();
            Assert.IsTrue(result.GetType() == b.GetType());
        }

        [TestMethod]
        public void BlackListCreateTest_MustReturnOk()
        {
            var result = req.BlackList.Execute("5165158577299957", "prueba desde SDK");
            if (!string.IsNullOrEmpty(result))
            {
                Type a = result.GetType();
                var b = new Error();
                Assert.IsFalse((result.GetType() == b.GetType()) &&
                               ((Error) result).Description != "Card is already in Blacklist.");

                Assert.IsTrue(((Error)result).Description == "Card is already in Blacklist.");
            }
            else
            {
                Assert.IsTrue(string.IsNullOrEmpty(result));
            }
        }

        [TestMethod]
        public void BlackListDeleteTest_MustReturnOk()
        {
            var result = req.BlackList.Delete("5165158577299957");

            if (result != null)
            {
                Type a = result.GetType();
                var b = new Error();
                Assert.IsFalse((result.GetType() == b.GetType()) &&
                               ((Error) result).Description != "Card not found in Blacklist.");

                Assert.IsTrue(((Error)result).Description == "Card not found in Blacklist.");
            }
            else
            {
                Assert.IsTrue(string.IsNullOrEmpty(result.ToString()));
            }
        }


        [TestMethod]
        public void BlackListListTest_MustReturnOk()
        {
            var result = req.BlackList.List();

                Type a = result.GetType();
                var b = new Error();
                Assert.IsFalse((result.GetType() == b.GetType()) &&
                               ((Error)result).Description != "Card not found in Blacklist.");

            Assert.IsTrue(((GenericList<BlackListResponse>)result).TotalCount >= 0);
        }
    }
}
