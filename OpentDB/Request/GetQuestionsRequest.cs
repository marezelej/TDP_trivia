using OpentDB.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Request
{
    /// <summary>
    /// Un objeto request con la informacion para obtener las preguntas
    /// </summary>
    public class GetQuestionsRequest
    {
        /// <summary>
        /// La categoria de las preguntas a obtener
        /// </summary>
        public QuestionCategory Category { get; set; }

        /// <summary>
        /// La dificultad de las preguntas a obtener
        /// </summary>
        public QuestionDifficulty Difficulty { get; set; }

        /// <summary>
        /// La cantidad de preguntas a obtener
        /// </summary>
        public int Quantity { get; set; } = 10;

        /// <summary>
        /// El tipo de preguntas a obtener
        /// </summary>
        public QuestionType Type { get; internal set; }
    }
}
