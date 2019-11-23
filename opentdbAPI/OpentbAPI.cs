using System;
using System.Collections.Generic;

namespace opentdbAPI
{
    public class OpentbAPI
    {
        private IController iController;

        public OpentbAPI()
        {
            iController = new OpentbController();
        }

        /// <summary>
        /// Obtiene una lista de preguntas
        /// </summary>
        /// <param name="pNumber">El número de preguntas a obtener</param>
        /// <param name="pCategory">La categoría de las preguntas a obtener</param>
        /// <param name="pDifficulty">La dificultad de las preguntas</param>
        /// <param name="pType">El tipo de las preguntas</param>
        /// <returns>Una lista con las preguntas obtenidas</returns>
        public IEnumerable<QuestionDTO> GetQuestionsList(int pNumber, Category pCategory, Difficulty pDifficulty, QuestionType pType)
        {
            GetQuestionRequest request = new GetQuestionRequest();

            GetQuestionResponse response = iController.GetQuestions(request);

            if(response.HasError())
            {
                throw new APIException(response.Error);
            }

            
            return new List<QuestionDTO>();
        }
    }
}
