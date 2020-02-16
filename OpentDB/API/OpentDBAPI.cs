using OpentDB.Contract;
using OpentDB.Controller;
using OpentDB.IO;
using OpentDB.Request;
using OpentDB.Response;
using System;
using System.Collections.Generic;

namespace OpentDB.API
{
    public class OpentDBAPI : IOpentDBAPI
    {
        private IQuestionsController iController = new QuestionsController();

        /// <summary>
        /// Obtiene una lista de preguntas
        /// </summary>
        /// <param name="pNumber">El número de preguntas a obtener</param>
        /// <param name="pCategory">La categoría de las preguntas a obtener</param>
        /// <param name="pDifficulty">La dificultad de las preguntas</param>
        /// <param name="pType">El tipo de las preguntas</param>
        /// <returns>Una lista con las preguntas obtenidas</returns>
        public IEnumerable<QuestionDTO> GetQuestionsList(int pNumber, QuestionCategory pCategory, QuestionDifficulty pDifficulty, QuestionType pType)
        {
            GetQuestionsRequest request = new GetQuestionsRequest();

            GetQuestionsResponse response = iController.GetQuestions(request);

            if(response.HasError())
            {
                throw new Exception(response.Error);
            }
            
            return response.Questions;
        }
    }
}
