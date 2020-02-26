using System;
using System.Collections.Generic;
using TriviaGame.Domain;
using TriviaGame.IO;

namespace QuestionsAdapters
{
    /// <summary>
    /// Adaptador encargado de obtener las preguntas de un conjunto de preguntas
    /// </summary>
    public interface IQuestionsAdapter
    {
        /// <summary>
        /// Obtiene las preguntas del conjunto de preguntas
        /// </summary>
        /// <param name="pCategory">La categoria de las preguntas o null para todas</param>
        /// <param name="pDifficulty">La dificultad de las preguntas o null para todas</param>
        /// <param name="pQuantity">La cantidad de las preguntas o null para todas</param>
        /// <returns>Una lista de preguntas</returns>
        IList<QuestionDTO> GetQuestions(CategoryDTO pCategory, DiffucultyDTO pDifficulty, int pQuantity);

        /// <summary>
        /// Devuelve el set de preguntas con sus categorias y dificultades
        /// </summary>
        /// <returns>Un set de preguntas</returns>
        QuestionsSet GetSet();
    }
}
