using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.DAL
{
    /// <summary>
    /// Representa una UnitOfWork para trabajar de manera transaccional con la base de datos
    /// </summary>
    interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// El repositorio de usuarios
        /// </summary>
        IUserRepository UserRepository { get; }

        /// <summary>
        /// El repositorio de sesiones
        /// </summary>
        ISessionRepository SessionRepository { get; }

        /// <summary>
        /// El repositorio de conjuntos de preguntas
        /// </summary>
        IQuestionsSetRepository QuestionsSetRepository { get; }

        /// <summary>
        /// Completa la transacción
        /// </summary>
        void Complete();
    }
}
