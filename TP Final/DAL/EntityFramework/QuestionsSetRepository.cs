using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework
{
    class QuestionsSetRepository : Repository<QuestionsSet, TriviaDbContext>, IQuestionsSetRepository
    {
        /// <summary>
        /// Construye el repositorio utilizando el DbContext dado
        /// </summary>
        public QuestionsSetRepository(TriviaDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}
