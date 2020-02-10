using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    /// <summary>
    /// Representa la relación de una pregunta con una sesión de trivia.
    /// Guarda información como el tiempo que se tardó en contestar la pregunta 
    /// y la respuesta elegida.
    /// </summary>
    class SessionQuestion
    {
        internal int Id { get; set; }
        internal TimeSpan Time { get; set; }
        internal Session Session { get; set; }
        internal Question Question { get; set; }
        internal Answer SelectedAnswer { get; set; }
    }
}
