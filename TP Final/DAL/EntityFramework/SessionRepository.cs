using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework
{
    /// <summary>
    /// Un repositorio de sesiones implementado en EntityFramework
    /// </summary>
    internal class SessionRepository : Repository<Session, TriviaDbContext>, ISessionRepository
    {
        /// <summary>
        /// Construye el repositorio utilizando el DbContext dado
        /// </summary>
        public SessionRepository(TriviaDbContext pDbContext) : base(pDbContext)
        {

        }

        public Session GetBestSession(int pUserId)
        {
            return  iDbContext.Sessions.
                Where(pSession => pSession.User.Id == pUserId).
                OrderByDescending(pSession => pSession.Score).
                FirstOrDefault();
        }
    }
}
