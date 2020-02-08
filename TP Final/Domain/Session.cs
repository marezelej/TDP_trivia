using System;
using System.Collections.Generic;

namespace TP_Final.Domain
{
    /// <summary>
    /// Una sesión de preguntas
    /// </summary>
    internal class Session
    {
        internal int Id { get; set; }
        internal int Score { get; set; }
        internal int Quantity { get; set; }
        internal TimeSpan Time { get; set; }

        /* AGREGAR LUEGO
        internal Set Set { get; set; }
        internal Category Category { get; set; }
        internal Difficulty Difficulty { get; set; }
        internal IList<Question> Questions { get; set; } */
    }
}