using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.Domain
{
    /// <summary>
    /// Representa la relación de una pregunta con una sesión de trivia.
    /// Guarda información como el tiempo que se tardó en contestar la pregunta 
    /// y la respuesta elegida.
    /// </summary>
    public class SessionQuestion
    {
        public int Id { get; set; }
        public TimeSpan Time { get; set; }
        public virtual Question Question { get; set; }
        public virtual Answer SelectedAnswer { get; set; }
    }
}
