using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.DAL.EntityFramework
{
    /// <summary>
    /// Un repositorio de entidades de clase TEntity implementado utilizando entity framework
    /// </summary>
    /// <typeparam name="TEntity">La entidad a almacenar</typeparam>
    public abstract class Repository<TEntity, TDbContext> : IRepository<TEntity> where TEntity : class where TDbContext : DbContext
    {
        protected readonly TDbContext iDbContext;

        /// <summary>
        /// Construye el repositorio para un contexto dado
        /// </summary>
        /// <param name="pDbContext">El DbContext a utilizar</param>
        public Repository(TDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new ArgumentNullException(nameof(pDbContext));
            }

            this.iDbContext = pDbContext;
        }

        /// <summary>
        /// Agrega una entidad pEntity al repositorio
        /// </summary>
        /// <param name="pEntity">La entidad a agregar</param>
        public void Add(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Add(pEntity);
        }

        /// <summary>
        /// Obtiene la entidad de id pId del repositorio
        /// </summary>
        /// <param name="pId">El id de la entidad buscada</param>
        /// <returns>La entidad buscada</returns>
        public TEntity Get(int pId)
        {
            return iDbContext.Set<TEntity>().Find(pId);
        }

        /// <summary>
        /// Devuelve todas las entidades del repositorio
        /// </summary>
        /// <returns>Todas las entidades del repositorio</returns>
        public IEnumerable<TEntity> GetAll()
        {
            return iDbContext.Set<TEntity>();
        }

        /// <summary>
        /// Remueve una entidad del repositorio
        /// </summary>
        /// <param name="pEntity">La entidad a remover</param>
        public void Remove(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            iDbContext.Set<TEntity>().Remove(pEntity);
        }
    }
}
