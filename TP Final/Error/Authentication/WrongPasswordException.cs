using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.Error.Authentication
{
    /// <summary>
    /// Se lanza cuando la contraseña dada es incorrecta
    /// </summary>
    public class WrongPasswordException: AuthenticationException
    {
    }
}
