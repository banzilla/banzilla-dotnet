using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banzilla.Client;
using Banzilla.Client.Models;
using Banzilla.Client.Utils;
using Newtonsoft.Json;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            APIRequest req = new APIRequest("BZS-1SRS-VNBi3F", "A24R-2DRV-K3J2X", true);
            GetTokensList(req);

            Console.ReadLine();
        }

        public static void chargeCardTest(APIRequest req)
        {
            var Address = new Address()
            {
                Number = "13",
                State = "CX",
                City = "Puebla",
                Street = "Desconocida",
                ZipCode = "73310",
                Country = "MXN",
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

            Console.WriteLine(JsonConvert.DeserializeObject(result.ToString()));
        }


        public static void ChargeTokenTest(APIRequest req)
        {
            var result= req.Charge.Execute(new ChargeToken()
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

            Console.WriteLine(JsonConvert.DeserializeObject<object>(result));
        }

        public static void GetTokensList(APIRequest req)
        {
            var result =req.Cards.List();
        }

        public static void CreateToken(APIRequest req)
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

           var result =  req.Cards.Execute(new Token()
            {
                Card = new Card()
                {
                    Address = address,
                    CardNumber = "347639702413920",
                    SecurityCode = "8375",
                    HolderName = "Arturo Perea",
                    ExpYear = "17",
                    ExpMonth = "08"
                },
                MiddleName = "Perea",
                FirstName = "Arturo",
                LastName = "Rodriguez",
                Email = "artcce@hotmail.com",
             PhoneNumber = "5527251902"
            });
            
            Console.Write(result.ToString());
        }


        public static void SearchToken(APIRequest req)
        {
            var result = req.Cards.Search("");

        }

        public static void AddCardToBlacklist(APIRequest req)
        {
            var result= req.BlackList.Execute("347639702413920", "prueba de blacklist desde sdk");

        }

        public static void ReadBlacklist(APIRequest req)
        {
            var result = req.BlackList.List();

        }

        public static void DeleteBlackList(APIRequest req)
        {
            req.BlackList.Delete("347639702413920");
        }
    }
}
