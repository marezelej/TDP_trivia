using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.Error.Authentication
{
    /// <summary>
    /// Se lanza cuando no hay un usuario autenticado en el sistema
    /// </summary>
    public class NonAuthenticationException : Exception
    {
    }
}
