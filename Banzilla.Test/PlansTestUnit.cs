using System;
using System.Collections.Generic;
using Banzilla.Client;
using Banzilla.Client.Controller;
using Banzilla.Client.Models;
using Banzilla.Client.Response;
using Banzilla.Client.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banzilla.Test
{
    [TestClass]
    public class PlansTestUnit
    {
        private APIRequest req;
        public PlansTestUnit()
        {
            req = new APIRequest("BZS-1SRS-VNBi3F", "A24R-2DRV-K3J2X", true); //Sandbox
        }
        [TestMethod]
        public void PlanExecute_MustReturnOk()
        {
            var result= req.Plans.Create(new Plan()
            {
                Description = "r2 TEst",
                Amount = 10,
                MaxAttempts = 1,
                Frequency = 3,
                PlanDuration = 3,
                PlanName = "r2",
                RepeatEvery = 1
            });

            Type a = result.GetType();
            var b = new Error();
            var x = new PlanResponse();

            bool validateErrorType = result.GetType() == b.GetType();
            //If error but
            Assert.IsFalse(validateErrorType);

            Assert.IsTrue(result.GetType() == x.GetType());

        }

        [TestMethod]
        public void PlanExecute_MustReturnError()
        {
            var result = req.Plans.Create(new Plan()
            {
                Description = "r2 TEst",
                Amount = 10,
                MaxAttempts = 1,
                Frequency = 3,
                PlanDuration = 3,
                RepeatEvery = 1
            });

            Type a = result.GetType();
            var b = new Error();
            var x = new PlanResponse();

            bool validateErrorType = result.GetType() == b.GetType();
            //If error but
            Assert.IsTrue(validateErrorType);

        }


        [TestMethod]
        public void PlanList_MustReturnListOFPlans()
        {
            var result = req.Plans.List(new ListRequest() {page = 1, size = 20});
            Type a = result.GetType();
            var b = new Error();
            var x = new GenericList<PlanResponse>();

            bool validateErrorType = result.GetType() == b.GetType();
            //If error but
            Assert.IsFalse(validateErrorType);

            Assert.IsTrue(result.GetType() == x.GetType());
        }

        [TestMethod]
        public void PlanDelete_MustReturnOk()
        {
            var result = req.Plans.Delete("ZbajJlO8ZnL1XgV1");

            Assert.IsTrue(string.IsNullOrEmpty(result.ToString()) || ((Error)result).Description== "The specified plan does not exist or you are not allowed to see its detail.");
        }

        [TestMethod]
        public void PlanDelete_MustReturnError()
        {
            var result = req.Plans.Delete("ZbajJlO8ZnL1");
            var b = new Error();
            bool validateErrorType = result.GetType() == b.GetType();
            //If error but
            Assert.IsTrue(validateErrorType);
        }


        [TestMethod]
        public void PlanDeactivate_MustReturnOk()
        {
            var result = req.Plans.Inactivate("ZbajJlO8ZnL1XgV1");

            Assert.IsTrue(string.IsNullOrEmpty(result.ToString()) || ((Error)result).Description == "The specified plan does not exist or you are not allowed to see its detail.");
        }

    }
}
