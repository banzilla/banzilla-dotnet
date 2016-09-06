using System;
using System.Runtime.Remoting;
using Banzilla.Client;
using Banzilla.Client.Models;
using Banzilla.Client.Response;
using Banzilla.Client.Responses;
using Banzilla.Client.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Banzilla.Test
{
    [TestClass]
    public class ChargeCardTestUnit
    {
        private APIRequest req;
        public ChargeCardTestUnit()
        {
            req = new APIRequest("BZS-1SRS-VNBi3F", "A24R-2DRV-K3J2X", true); //Sandbox
        }


        [TestMethod]
        public void ChargeCardTest_MustReturnDeniedCharge()
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

            var result = req.Charge.Execute(new ChargeCard()
            {
                Card = new Card()
                {
                    Address = Address,
                    CardNumber = "347639702413920",
                    SecurityCode = "8375",
                    HolderName = "Arturo Perea",
                    ExpYear = "17",
                    ExpMonth = "08"
                },
                Customer = new Customer()
                {
                    Address = Address,
                    MiddleName = "Perea",
                    FirstName = "Arturo",
                    LastName = "Rodriguez",
                    Email = "artcce@gmail.com"
                },
                Description = "prueba de cargo",
                eGateway = eCardGateway.amex,
                Order = new Order()
                {
                    Reference = "123",
                    eCurrency = eCurrency.MXN,
                    Amount = 1500
                }
            });

            Type a =result.GetType();
            Assert.IsFalse(a.Equals(new Error()));

            Assert.IsTrue(((ChargeCardResponse)result).Status.ToLower() =="denied");
           
        }


        [TestMethod]
        public void ChargeCardTest_MustReturnErrorOnCharge()
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

            var result = req.Charge.Execute(new ChargeCard()
            {
                Card = new Card()
                {
                    Address = Address,
                    CardNumber = "3476397024139",
                    SecurityCode = "8375",
                    HolderName = "Arturo Perea",
                    ExpYear = "17",
                    ExpMonth = "08"
                },
                Customer = new Customer()
                {
                    Address = Address,
                    MiddleName = "Perea",
                    FirstName = "Arturo",
                    LastName = "Rodriguez",
                    Email = "artcce@gmail.com"
                },
                Description = "prueba de cargo",
                eGateway = eCardGateway.amex,
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

        [TestMethod]
        public void ChargeCardTest_MustReturnOkOnCharge()
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

            var result = req.Charge.Execute(new ChargeCard()
            {
                Card = new Card()
                {
                    Address = Address,
                    CardNumber = "341673881213039",
                    SecurityCode = "6168",
                    HolderName = "Arturo Perea",
                    ExpYear = "17",
                    ExpMonth = "10"
                },
                Customer = new Customer()
                {
                    Address = Address,
                    MiddleName = "Perea",
                    FirstName = "Arturo",
                    LastName = "Rodriguez",
                    Email = "artcce@gmail.com"
                },
                Description = "prueba de cargo",
                eGateway = eCardGateway.amex,
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

            Assert.IsFalse(((ChargeCardResponse)result).Status.ToLower() == "denied");

            Assert.IsTrue(((ChargeCardResponse)result).Status.ToLower() == "complete");

            Assert.IsTrue(!string.IsNullOrEmpty(((ChargeCardResponse)result).IdTransaction));

        }
    }
}
