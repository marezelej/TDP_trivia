using System;

namespace opentdbAPI
{
    public class GetQuestionResponse
    {
        private string iError;
        public string Error { get => iError; internal set => iError = value; }

        /// <summary>
        /// Setea la respuesta
        /// </summary>
        /// <param name="pResponse">La respuesta</param>
        internal void SetResponse(dynamic pResponse)
        {
            foreach (var bResponseItem in pResponse.results)
            {
                QuestionDTO question    = new QuestionDTO();

                question.Question       = bResponseItem.question;
                question.Difficulty     = bResponseItem.difficulty;
                question.Type           = bResponseItem.type;
                question.Category       = bResponseItem.category;
                question.CorrectAnswer  = bResponseItem.correct_answer;
                foreach (string bIncorrectAnswer in bResponseItem.incorrect_answers)
                {
                    question.AddIncorrectAnswer(bIncorrectAnswer);
                }

            }
        }
        /// <summary>
        /// Determina si la respuesta tuvo algun error
        /// </summary>
        /// <returns>Verdadero si hubo algun error</returns>
        internal bool HasError()
        {
            return iError != null;
        }

        internal void AddQuestionFromResponse(dynamic bResponseItem)
        {
            throw new NotImplementedException();
        }
    }
}