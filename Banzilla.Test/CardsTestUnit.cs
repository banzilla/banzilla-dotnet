using System;
using Banzilla.Client;
using Banzilla.Client.Models;
using Banzilla.Client.Response;
using Banzilla.Client.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banzilla.Test
{
    [TestClass]
    public class CardsTestUnit
    {
        private APIRequest req;
        public CardsTestUnit()
        {
            req = new APIRequest("BZS-1SRS-VNBi3F", "A24R-2DRV-K3J2X", true); //Sandbox
        }

        [TestMethod]
        public void CardsListTest_MustReturnListOfTokens()
        {
            var result = req.Cards.List();

            Type a = result.GetType();
            var b = new Error();
            Assert.IsFalse(result.GetType() == b.GetType());

            var x=new GenericList<TokenResponse>();
            Assert.IsTrue(result.GetType()==x.GetType());

            Assert.IsTrue(((GenericList<TokenResponse>)result).TotalCount>=0);
        }

        [TestMethod]
        public void CardExecute_MustReturnOk()
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

            var result = req.Cards.Create(new Token()
            {
                Card = new Card()
                {
                    Address = address,
                    CardNumber = "341192111079623",
                    SecurityCode = "4375",
                    HolderName = "Arturo Perea",
                    ExpYear = "19",
                    ExpMonth = "03"
                },
                MiddleName = "Perea",
                FirstName = "Arturo",
                LastName = "Rodriguez",
                Email = "artcce@hotmail.com",
                PhoneNumber = "5527251902"
            });

            Type a = result.GetType();
            var b = new Error();
            var x = new TokenResponse();

            bool validateErrorType = result.GetType() == b.GetType();
            bool validateDuplicatedToken = ((Error) result).Description.ToLower().Contains("card is already tokenized");
            //If error but
            Assert.IsTrue((validateErrorType && validateDuplicatedToken) || result.GetType() == x.GetType());
          
        }

        [TestMethod]
        public void CardExecure_MustReturnError()
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

            var result = req.Cards.Create(new Token()
            {
                MiddleName = "Perea",
                FirstName = "Arturo",
                LastName = "Rodriguez",
                Email = "artcce@hotmail.com",
                PhoneNumber = "5527251902"
            });

            Type a = result.GetType();
            var b = new Error();
            
            bool validateErrorType = result.GetType() == b.GetType();
            
            Assert.IsTrue(validateErrorType);

        }
        //TODO: cardDelete
        //[TestMethod]
        //public void CardDelete_MustReturnOk()
        //{
        //    //var result = req.Cards.Delete("");
        //    //Type a = result.GetType();
        //    //var b = new Error();

        //    //Assert.IsTrue(validateErrorType);

        //}


        //TODO: CardInactivate
    }
}
