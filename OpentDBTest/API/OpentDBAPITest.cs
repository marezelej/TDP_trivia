using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OpentDB.Controller;
using OpentDB.API;

namespace OpentDBTest.API
{
    [TestClass]
    public class OpentDBAPITest
    {
        [TestMethod]
        public void TestGetQuestionsList()
        {
            var bMockedController = new Mock<IQuestionsController>();



            OpentDBAPI bApi = new OpentDBAPI(bMockedController.Object);
        }
    }
}
