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
using TP_Final.IO;

namespace TP_Final
{
    public class SessionFacade : ISessionFacade
    {
        private static readonly IMapper cMapper;

        static SessionFacade()
        {
            var mConfiguration = new MapperConfiguration(pConfiguration =>
            {
                pConfiguration.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                pConfiguration.CreateMap<Session, SessionDTO>();
                pConfiguration.CreateMap<SessionDTO, Session>();
            });

            cMapper = mConfiguration.CreateMapper();
        }

        /// <summary>
        /// Obtiene la mejor sesion del usuario pasado
        /// </summary>
        /// <param name="pUserId">El id del usuario buscado</param>
        /// <returns>La mejor sesión del usuario o null si el usuario no posee sesiones</returns>
        public SessionDTO GetBestSession(int pUserId)
        {
            using (var bDbContext = new TriviaDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {

                    Session bBestSession = bUoW.SessionRepository.GetBestSession(pUserId);

                    bUoW.Complete();

                    return cMapper.Map<SessionDTO>(bBestSession);
                }
            }
        }

        public IList<QuestionsSetDTO> GetAvailableSets()
        {
            return new List<QuestionsSetDTO>()
            {
                new QuestionsSetDTO()
                {
                    Id              = 1,
                    Name            = "OpentDB",
                    Categories      = new List<CategoryDTO>()
                    {
                        new CategoryDTO()
                        {
                            Id      = 1,
                            Name    = "Categoria 1"
                        },
                        new CategoryDTO()
                        {
                            Id      = 2,
                            Name    = "Categoria 2"
                        },
                        new CategoryDTO()
                        {
                            Id      = 3,
                            Name    = "Categoria 3"
                        }
                    },
                    Difficulties    = new List<DiffucultyDTO>(),
                    MaxQuantity     = 10,
                }
            };
        }
    }
}
