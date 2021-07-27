using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Domain;

namespace TriviaGame.DAL.EntityFramework
{
    /// <summary>
    /// Un repositorio de usuarios implementado sobre EntityFramework
    /// </summary>
    internal class UserRepository : Repository<User, TriviaDbContext>, IUserRepository
    {
        /// <summary>
        /// Construye el repositorio utilizando el DbContext dado
        /// </summary>
        public UserRepository(TriviaDbContext pDbContext) : base(pDbContext)
        {

        }

        /// <summary>
        /// Devuelve el primer usuario con legajo pFileNumber
        /// </summary>
        /// <param name="pFileNumber">El número de legajo buscado</param>
        /// <returns>El primer usuario encontrado</returns>
        public User GetByFileNumber(string pFileNumber)
        {
            return iDbContext.Users.Where(u => u.FileNumber == pFileNumber).FirstOrDefault();
        }

        /// <summary>
        /// Elimina el primer usuario con legajo pFileNumber
        /// </summary>
        /// <param name="User">El usuario buscado</param>
        /// <returns>El primer usuario encontrado</returns>

        public void DeleteUser(User user)
        {
            return iDbContext.Users.Remove(u => u.FileNumber == user.pFileNumber).FirstOrDefault();
        }

         /// <summary>
        /// Devuelve la lista de Usuarios
        /// </summary>       
        /// <returns>Lista de usuarios en base de datos</returns>

        public List<User> getUserList()
        {
            using (var context = new MyContext())
            {
                return context.Users.ToList();
            }
        }
    }
}
