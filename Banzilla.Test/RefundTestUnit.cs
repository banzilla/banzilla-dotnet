using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client;
using Banzilla.Client.Models;
using Banzilla.Client.Response;
using Banzilla.Client.Responses;
using Banzilla.Client.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banzilla.Test
{
    [TestClass]
    public    class RefundTestUnit
{
        
        private APIRequest req;
        public RefundTestUnit()
        {
            req = new APIRequest("BZS-1SRS-VNBi3F", "A24R-2DRV-K3J2X", true); //Sandbox
        }

        [TestMethod]
        public void RefundTest_MustReturnError()
        {
            var result = req.Charge.Execute(new Refund()
            {
               Amount = 1,
              eCurrency = eCurrency.MXN,
              Reason = "Prueba",
              TransactionId = "123"
            });

            Type a = result.GetType();
            var b = new Error();
            Assert.IsTrue(result.GetType() == b.GetType());
        }
    }
}
