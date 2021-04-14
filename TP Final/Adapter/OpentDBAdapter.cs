using System;
using System.Collections.Generic;
using System.Text;
using TriviaGame.IO;
using OpentDB.Contract;
using OpentDB.IO;
using OpentDB.API;
using TriviaGame.Domain;
using TriviaGame.Contract;
using System.Linq;

namespace TriviaGame.Adapter
{
    class OpentDBAdapter : IQuestionsAdapter
    {
        IOpentDBAPI iApi = new OpentDBAPI();

        /// <summary>
        /// Devuelve una lista de preguntas obtenidas de OpentDB
        /// </summary>
        /// <param name="pCategory">La categoria de las preguntas o null para todas</param>
        /// <param name="pDifficulty">La dificultad de las preguntas o null para todas</param>
        /// <param name="pQuantity">La cantidad de las preguntas o null para todas</param>
        /// <returns>Una lista de preguntas</returns>
        public IList<QuestionDTO> GetQuestions(CategoryDTO pCategory, DiffucultyDTO pDifficulty, int pQuantity)
        {
            QuestionCategory bCategory = MapCategory(pCategory);
            QuestionDifficulty bDifficulty = MapDifficulty(pDifficulty);

            IEnumerable<IQuestion> bQuestions = iApi.GetQuestionsList(pQuantity, bCategory, bDifficulty, QuestionType.multiple);

            IList<QuestionDTO> bResult = new List<QuestionDTO>();
            foreach(IQuestion bQuestion in bQuestions)
            {
                bResult.Add(MapQuestion(bQuestion));
            }

            return bResult;
        }

        /// <summary>
        /// Mapea una dificultad de TriviaGame a la API
        /// </summary>
        /// <param name="pDifficulty">Una dificultad o null para cualquiera</param>
        /// <returns>La dificultad de la API correspondiente</returns>
        private QuestionDifficulty MapDifficulty(DiffucultyDTO pDifficulty)
        {
            if (pDifficulty == null)
                return QuestionDifficulty.Any;

            throw new NotImplementedException();
        }

        /// <summary>
        /// Mapea una categoria de TriviaGame a la API
        /// </summary>
        /// <param name="pCategory">Una categoria o null para cualquiera</param>
        /// <returns>La categoria de la API correspondiente</returns>
        private QuestionCategory MapCategory(CategoryDTO pCategory)
        {
            if (pCategory == null)
                return QuestionCategory.Any;

            throw new NotImplementedException();
        }

        /// <summary>
        /// Mapea una pregunta de la API a una pregunta de TriviaGame
        /// </summary>
        /// <param name="pQuestion"></param>
        /// <returns></returns>
        private QuestionDTO MapQuestion(IQuestion pQuestion)
        {
            QuestionDTO bQuestion = new QuestionDTO() { 
                Description =  pQuestion.Question,
                Answers = new List<AnswerDTO>()
            };

            bQuestion.Answers.Add(new AnswerDTO()
            {
                Description = pQuestion.CorrectAnswer,
                IsCorrect = true
            });

            foreach(string bAnswer in pQuestion.IncorrectAnswers)
            {
                bQuestion.Answers.Add(new AnswerDTO()
                {
                    Description = bAnswer,
                    IsCorrect = false
                });
            }

            return bQuestion;
        }

        /// <summary>
        /// Devuelve el set de preguntas de OpentDB
        /// </summary>
        /// <returns>El set de preguntas de OpentDB</returns>
        public QuestionsSet GetSet()
        {
            QuestionsSet bSet = new QuestionsSet()
            {
                Name = "Open Trivia DB",
                Categories = new List<Category>(),
                Difficulties = new List<Difficulty>(),
                Adapter = typeof(OpentDBAdapter).ToString()
            };

            Enum.GetValues(typeof(QuestionCategory));

            return bSet;
        }

        public float GetScore(IList<QuestionDTO> pQuestions, DiffucultyDTO pDificulty, int pSecondsSpent)
        {
            int bQuantity = pQuestions.Sum(q =>
                    Convert.ToInt16(q.SelectedAnswer != null && q.SelectedAnswer.IsCorrect)
                );
            int bCorrectQuantity = pQuestions.Count;
            float bQuestionsFactor = bCorrectQuantity / bQuantity;
            return bQuestionsFactor * pDificulty.Weight * GetTimeFactor(pSecondsSpent / bQuantity);
        }

        private int GetTimeFactor(float bAverageTime)
        {
            if (bAverageTime < 5)
                return 5;
            if (bAverageTime <= 20)
                return 3;
            return 1;
        }
    }
}
