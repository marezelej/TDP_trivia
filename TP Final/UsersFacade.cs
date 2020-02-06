using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.IO;

namespace TP_Final
{
    public class UsersFacade
    {
        /// <summary>
        /// Crea un nuevo usuario en el sistema
        /// </summary>
        /// <param name="pUser">El usuario a crear</param>
        public void CreateUser(UserDTO pUser)
        {

        }

        /// <summary>
        /// Obtiene un usuario dado de alta en el sistema
        /// </summary>
        /// <param name="pFileNumber">El legajo del usuario buscado</param>
        /// <returns></returns>
        public UserDTO GetUser(string pFileNumber)
        {
            throw new Exception("not implemented");
        }

        public bool Authenticate(string fileNumber, string password)
        {
            return true;
        }

        public UserDTO GetAuthenticatedUser()
        {
            return new UserDTO()
            {
                Id = 1,
                FirstName = "Martín",
                LastName = "Lejman",
                FileNumber = "14119550"
            };
        }

        public void LogOutAuthenticatedUser()
        {

        }
    }
}
