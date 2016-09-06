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
    public  class ChargeStoreTestUnit
    {
        private APIRequest req;
        public ChargeStoreTestUnit()
        {
            req = new APIRequest("BZS-1SRS-VNBi3F", "A24R-2DRV-K3J2X", true); //Sandbox
        }

        [TestMethod]
        public void ChargeStoreTest_MustReturnInProcessCharge()
        {
            var Address = new Address()
            {
                Number = "13",
                State = "CX",
                City = "Puebla",
                Street = "Desconocida",
                ZipCode = "73310",
                Country = "MEX",
                Apartment = "123"
            };

            var result = req.Charge.Execute(new ChargeStore()
            {
             
                Customer = new Customer()
                {
                    Address = Address,
                    MiddleName = "Perea",
                    FirstName = "Arturo",
                    LastName = "Rodriguez",
                    Email = "artcce@gmail.com"
                },
                Description = "prueba de cargo",
                eGateway = eStoreGateways.oxxo,
                DueDate = DateTime.Now.AddDays(7),
                Order = new Order()
                {
                    Reference = "123",
                    eCurrency = eCurrency.MXN,
                    Amount = 1500
                }
            });


            Type a = result.GetType();
            var b = new Error();
            Assert.IsFalse(result.GetType() == b.GetType());

            Assert.IsTrue(((ChargeStoreResponse)result).Status.ToLower().Contains("process"));

        }


        [TestMethod]
        public void ChargeStoreTest_MustReturnErrorCharge()
        {
            var Address = new Address()
            {
                Number = "13",
                State = "CX",
                City = "Puebla",
                Street = "Desconocida",
                ZipCode = "73310",
                Country = "MEX",
                Apartment = "123"
            };

            var result = req.Charge.Execute(new ChargeStore()
            {

              
                Description = "prueba de cargo",
                eGateway = eStoreGateways.oxxo,
                DueDate = DateTime.Now.AddDays(7),
                Order = new Order()
                {
                    Reference = "123",
                    eCurrency = eCurrency.MXN,
                    Amount = 1500
                }
            });


            Type a = result.GetType();
            var b = new Error();
            Assert.IsTrue(result.GetType() == b.GetType());
        }
    }
}
