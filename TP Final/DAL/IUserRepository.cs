using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL
{
    /// <summary>
    /// Un repositorio de usuarios
    /// </summary>
    interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Devuelve el usuario con el número de legajo pasado
        /// </summary>
        /// <param name="pFileNumber">El número de legajo del usuario buscado</param>
        /// <returns>El usuario buscado</returns>
        User GetByFileNumber(string pFileNumber);
    }
}
