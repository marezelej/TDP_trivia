using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.DAL
{
    /// <summary>
    /// Representa un repositorio de entidades de clase TEntity
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Agrega una entidad al repositorio
        /// </summary>
        /// <param name="pEntity">La entidad a agregar</param>
        void Add(TEntity pEntity);

        /// <summary>
        /// Remueve una entidad del repositorio
        /// </summary>
        /// <param name="pEntity">La entidad a remover</param>
        void Remove(TEntity pEntity);

        /// <summary>
        /// Obtiene la entidad de id pId del repositorio
        /// </summary>
        /// <param name="pId">El id de la entidad buscada</param>
        /// <returns>La entidad buscada</returns>
        TEntity Get(int pId);

        /// <summary>
        /// Devuelve todas las entidades del repositorio
        /// </summary>
        /// <returns>Todas las entidades del repositorio</returns>
        IEnumerable<TEntity> GetAll();
    }
}
