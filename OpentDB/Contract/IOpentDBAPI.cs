using OpentDB.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Contract
{
    public interface IOpentDBAPI
    {
        /// <summary>
        /// Obtiene una lista de preguntas
        /// </summary>
        /// <param name="pNumber">El número de preguntas a obtener</param>
        /// <param name="pCategory">La categoría de las preguntas a obtener</param>
        /// <param name="pDifficulty">La dificultad de las preguntas</param>
        /// <param name="pType">El tipo de las preguntas</param>
        /// <returns>Una lista con las preguntas obtenidas</returns>
        IEnumerable<IQuestion> GetQuestionsList(int pNumber, QuestionCategory pCategory, QuestionDifficulty pDifficulty, QuestionType pType);
    }
}
