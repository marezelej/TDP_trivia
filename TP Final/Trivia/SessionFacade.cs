using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.IO;

namespace TP_Final
{
    public class SessionFacade
    {
        /// <summary>
        /// Obtiene la mejor sesion del usuario pasado
        /// </summary>
        /// <param name="pUserId">El id del usuario buscado</param>
        /// <returns>La mejor sesión del usuario</returns>
        public SessionDTO GetBestSession(int pUserId)
        {
            return new SessionDTO()
            {
                Id = 1,
                UserId = pUserId,
                Quantity = 10,
                Score = 100,
                Time = new TimeSpan(0, 10, 15)
            };
        }

        public IList<SetDTO> GetAvailableSets()
        {
            return new List<SetDTO>()
            {
                new SetDTO()
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
