using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.DAL.EntityFramework
{
    /// <summary>
    /// Una UnitOfWork para entity fraemwork
    /// </summary>
    class UnitOfWork : IUnitOfWork
    {
        private readonly TriviaDbContext iDbContext;

        private bool iDisposedValue = false;

        /// <summary>
        /// El repositorio de usuarios utilizado
        /// </summary>
        public IUserRepository UserRepository { get; private set; }

        /// <summary>
        /// El repositorio de sesiones
        /// </summary>
        public ISessionRepository SessionRepository { get; private set; }

        /// <summary>
        /// Construye la UnitOfWork para el DbContext dado
        /// </summary>
        /// <param name="pDbContext">El DbContext a utilizar</param>
        public UnitOfWork(TriviaDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new Exception("El DbCOntext no puede ser nulo");
            }

            this.iDbContext = pDbContext;
            this.UserRepository = new UserRepository(pDbContext);
            this.SessionRepository = new SessionRepository(pDbContext);
        }

        /// <summary>
        /// Completa la transacción
        /// </summary>
        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }

        protected virtual void Dispose(bool pDisposing)
        {
            if (!this.iDisposedValue)
            {
                if (pDisposing)
                {
                    this.iDbContext.Dispose();
                }

                this.iDisposedValue = true;
            }
        }

        /// <summary>
        /// Borra el objeto de memoria
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }
    }
}
