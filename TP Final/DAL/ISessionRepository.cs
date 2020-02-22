using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Domain;

namespace TriviaGame.DAL
{
    /// <summary>
    /// Un repositorio de sesiones
    /// </summary>
    interface ISessionRepository : IRepository<Session>
    {
        /// <summary>
        /// Devuelve la mejor sesión del usuario
        /// </summary>
        /// <param name="pUserId">El ID del usuario</param>
        /// <returns>La mejor sesión o null si el usuario no tiene sesiones</returns>
        Session GetBestSession(int pUserId);
    }
}
