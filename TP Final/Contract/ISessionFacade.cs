using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.IO;

namespace TP_Final.Contract
{
    /// <summary>
    /// Una fachada de sesión, con los métodos para AB
    /// </summary>
    public interface ISessionFacade
    {
        /// <summary>
        /// Devuelve la mejor sesión del usuario
        /// </summary>
        /// <param name="pUserId">El ID del usuario</param>
        /// <returns>La mejor sesión del usuario o null el usuario no posee sesiones</returns>
        SessionDTO GetBestSession(int pUserId);


    }
}
