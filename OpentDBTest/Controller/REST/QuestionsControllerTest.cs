using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OpentDB.Controller;
using OpentDB.Controller.REST.Service;
using OpentDB.Controller.REST.Service.Error;
using OpentDB.IO;
using OpentDB.Request;
using OpentDB.Response;

namespace OpentDBTest.Controller.REST
{
    [TestClass]
    public class QuestionsControllerTest
    {
        [TestMethod]
        public void TestGetQuestionsSuccess()
        {
            var bMockedService = new Mock<IWebService>();

            bMockedService.Setup(b => b.Get("https://opentdb.com/api.php?&amount=2&type=multiple")).Returns("{\"response_code\":0,\"results\":[{\"category\":\"Mythology\",\"type\":\"multiple\",\"difficulty\":\"medium\",\"question\":\"In Greek Mythology, who killed Achilles?\",\"correct_answer\":\"Paris\",\"incorrect_answers\":[\"Hector\",\"Helen\",\"Pericles\"]},{\"category\":\"Entertainment: Music\",\"type\":\"multiple\",\"difficulty\":\"medium\",\"question\":\"Rick Astley&#039;s hit song &quot;Never Gonna Give You Up&quot; was released in what year?\",\"correct_answer\":\"1987\",\"incorrect_answers\":[\"1985\",\"1986\",\"1988\"]}]}");

            QuestionsController bController = new QuestionsController(bMockedService.Object);

            GetQuestionsRequest bRequest = new GetQuestionsRequest();

            bRequest.Quantity = 2;
            bRequest.Type = QuestionType.multiple;

            IGetQuestionsResponse bResponse = bController.GetQuestions(bRequest);

            Assert.IsFalse(bResponse.HasError());
            Assert.IsNull(bResponse.Error);

            Assert.AreEqual(0, bResponse.ResponseCode);

            Assert.IsNotNull(bResponse.Questions);

            IList<IQuestion> bQuestions = bResponse.Questions.ToList();

            Assert.AreEqual(2, bQuestions.Count);

            IQuestion bQuestion1 = bQuestions[0];

            Assert.AreEqual(QuestionCategory.Mythology, bQuestion1.Category);
            Assert.AreEqual(QuestionDifficulty.medium, bQuestion1.Difficulty);
            Assert.AreEqual("In Greek Mythology, who killed Achilles?", bQuestion1.Question);
            Assert.AreEqual("Paris", bQuestion1.CorrectAnswer);
            Assert.AreEqual("Hector", bQuestion1.IncorrectAnswers[0]);
            Assert.AreEqual("Helen", bQuestion1.IncorrectAnswers[1]);
            Assert.AreEqual("Pericles", bQuestion1.IncorrectAnswers[2]);

            IQuestion bQuestion2 = bQuestions[1];

            Assert.AreEqual(QuestionCategory.Music, bQuestion2.Category);
            Assert.AreEqual(QuestionDifficulty.medium, bQuestion2.Difficulty);
            Assert.AreEqual("Rick Astley's hit song \"Never Gonna Give You Up\" was released in what year?", bQuestion2.Question);
            Assert.AreEqual("1987", bQuestion2.CorrectAnswer);
            Assert.AreEqual("1985", bQuestion2.IncorrectAnswers[0]);
            Assert.AreEqual("1986", bQuestion2.IncorrectAnswers[1]);
            Assert.AreEqual("1988", bQuestion2.IncorrectAnswers[2]);
        }

        [TestMethod]
        public void TestGetQuestionsServerError()
        {
            var bMockedService = new Mock<IWebService>();

            bMockedService.Setup(b => b.Get(It.IsAny<string>())).Throws(new CommunicationException("Server error"));

            QuestionsController bController = new QuestionsController(bMockedService.Object);

            GetQuestionsRequest bRequest = new GetQuestionsRequest();

            IGetQuestionsResponse bResponse = bController.GetQuestions(bRequest);

            Assert.IsTrue(bResponse.HasError());
            Assert.AreEqual("Error de comunicacion con el servidor: 'Server error'", bResponse.Error);
        }
    }
}
