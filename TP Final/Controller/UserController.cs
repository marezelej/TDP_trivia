﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Contract;
using TriviaGame.DAL;
using TriviaGame.DAL.EntityFramework;
using TriviaGame.Domain;
using TriviaGame.Error.Authentication;
using TriviaGame.Error.User;
using TriviaGame.IO;

namespace TriviaGame.Controller
{
    public class UserController: IUserController
    {
        private static readonly IMapper cMapper;
        private static UserDTO cAuthenticatedUser;

        static UserController()
        {
            var mConfiguration = new MapperConfiguration(pConfiguration =>
            {
                pConfiguration.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
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
                    if (bUoW.UserRepository.GetByFileNumber(pUser.FileNumber) != null)
                        throw new UserExistsException();

                    User bUser = new User()
                    {
                        FirstName = pUser.FirstName,
                        LastName = pUser.LastName,
                        FileNumber = pUser.FileNumber,
                        Password = pUser.Password
                    };

                    bUoW.UserRepository.Add(bUser);

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

                    cAuthenticatedUser = cMapper.Map<User, UserDTO>(bUser);
                    
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
