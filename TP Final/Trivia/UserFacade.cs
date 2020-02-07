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
using TP_Final.Error.Authentication;
using TP_Final.IO;

namespace TP_Final.Trivia
{
    public class UserFacade: IUserFacade
    {
        private static readonly IMapper cMapper;
        private static UserDTO cAuthenticatedUser;

        static UserFacade()
        {
            var mConfiguration = new MapperConfiguration(pConfiguration =>
            {
                pConfiguration.CreateMap<User, UserDTO>();
            });

            cMapper = mConfiguration.CreateMapper();
        }

        /// <summary>
        /// Crea un nuevo usuario en el sistema
        /// </summary>
        /// <param name="pUser">El usuario a crear</param>
        public void CreateUser(UserDTO pUser)
        {
            using (var bDbContext = new TriviaDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    User user = UserFacade.cMapper.Map<User>(pUser);

                    bUoW.UserRepository.Add(user);

                    bUoW.Complete();
                }
            }
        }

        /// <summary>
        /// Obtiene un usuario dado de alta en el sistema
        /// </summary>
        /// <param name="pFileNumber">El legajo del usuario buscado</param>
        /// <returns></returns>
        public UserDTO GetUser(string pFileNumber)
        {
            return new UserDTO();
        }

        /// <summary>
        /// Actualiza el usuario dado
        /// </summary>
        /// <param name="pUser">El usuario a actualizar</param>
        public void UpdateUser(UserDTO pUser)
        {
            CreateUser(pUser);
        }

        /// <summary>
        /// Autentica el usuario
        /// </summary>
        /// <param name="pFileNumber">El número de legajo del usuario</param>
        /// <param name="pPassword">La contraseña del usuario</param>
        /// <returns>El usuario autenticado</returns>
        public UserDTO Authenticate(string pFileNumber, string pPassword)
        {
            using (var bDbContext = new TriviaDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    User bUser = bUoW.UserRepository.GetByFileNumber(pFileNumber);

                    if(bUser == null)
                        throw new WrongFileNameException();

                    if(bUser.Password != pPassword)
                        throw new WrongPasswordException();

                    bUoW.Complete();

                    cAuthenticatedUser = cMapper.Map<UserDTO>(bUser);
                    
                    return cAuthenticatedUser;
                }
            }
        }

        /// <summary>
        /// Devuelve el usuario autenticado en el sistema o lanza una 
        /// exceptción en caso de que no haya ninguno
        /// </summary>
        /// <returns>El usuario autenticado</returns>
        public UserDTO GetAuthenticatedUser()
        {
            if (cAuthenticatedUser == null)
                throw new NonAuthenticationException();

            return cAuthenticatedUser;
        }

        /// <summary>
        /// Modifica la contraseña del usuario autenticado
        /// </summary>
        /// <param name="pNewPassword">La nueva contraseña a utilizar</param>
        public void ChangeAuthenticatedUserPassword(string pNewPassword)
        {
            using (var bDbContext = new TriviaDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    User bUser = bUoW.UserRepository.Get(GetAuthenticatedUser().Id);

                    if (bUser == null)
                        throw new Exception();

                    bUser.Password = pNewPassword;

                    bUoW.UserRepository.Add(bUser);

                    bUoW.Complete();
                }
            }
        }

        /// <summary>
        /// Desconecta al usuario autenticado
        /// </summary>
        public void LogOutAuthenticatedUser()
        {
            cAuthenticatedUser = null;
        }
    }
}
