using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.IO;

namespace TriviaGame.Contract
{
    /// <summary>
    /// Se encarga de administrar los usuarios del sistema.
    /// Permite el ABM, así como tambien autenticar usuarios y cambiar contraseñas.
    /// </summary>
    public interface IUserController
    {
        /// <summary>
        /// Crea un nuevo usuario en el sistema
        /// </summary>
        /// <param name="pUser">El usuario a crear</param>
        void CreateUser(UserDTO pUser);

        /// <summary>
        /// Obtiene un usuario dado de alta en el sistema
        /// </summary>
        /// <param name="pFileNumber">El legajo del usuario buscado</param>
        /// <returns></returns>
        UserDTO GetUser(string pFileNumber);

        /// <summary>
        /// Actualiza el usuario dado
        /// </summary>
        /// <param name="pUser">El usuario actualizado</param>
        void UpdateUser(UserDTO pUser);

        /// <summary>
        /// Permite autenticar un usuario por su número de legajo y contraseña
        /// </summary>
        /// <param name="fileNumber"></param>
        /// <param name="password"></param>
        /// <returns>El usuario autenticado en el sistema</returns>
        UserDTO Authenticate(string fileNumber, string password);

        /// <summary>
        /// Devuelve el usuario autenticado en el sistema
        /// </summary>
        /// <returns>El usuario autenticado en el sistema</returns>
        UserDTO GetAuthenticatedUser();

        /// <summary>
        /// Cierra la sesión actual del usuario autenticado
        /// </summary>
        void LogOutAuthenticatedUser();

        /// <summary>
        /// Cambia la contraseña del usuario autenticado
        /// </summary>
        /// <param name="pNewPassword"></param>
        void ChangeAuthenticatedUserPassword(string pNewPassword);
    }
}
