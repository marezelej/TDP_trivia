using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Contract;
using TP_Final.DAL;
using TP_Final.DAL.EntityFramework;
using TP_Final.Domain;

namespace TP_Final.Controller
{
    public class QuestionsSetController : IQuestionsSetController
    {
        private static readonly IMapper cMapper;

        static QuestionsSetController()
        {
            var mConfiguration = new MapperConfiguration(pConfiguration =>
            {
                pConfiguration.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                pConfiguration.CreateMap<QuestionsSet, QuestionsSetDTO>();
                pConfiguration.CreateMap<QuestionsSetDTO, QuestionsSet>();
            });

            cMapper = mConfiguration.CreateMapper();
        }

        /// <summary>
        /// Devuelve todos los conjuntos disponibles del sistema
        /// </summary>
        /// <returns>Los conjuntos disponibles en el sistema</returns>
        public IEnumerable<QuestionsSetDTO> GetAll()
        {
            using (var bDbContext = new TriviaDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    IEnumerable<QuestionsSet> bSetList = bUoW.QuestionsSetRepository.GetAll();

                    IEnumerable<QuestionsSetDTO> bResult = cMapper.Map<IEnumerable<QuestionsSetDTO>>(bSetList);

                    bUoW.Complete();

                    return bResult;
                }
            }
        }
    }
}
