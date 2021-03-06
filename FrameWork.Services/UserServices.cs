﻿using System;
using FrameWork.Repository;
using FrameWork.Model;
using Microsoft.Extensions.Logging;

namespace FrameWork.Services
{
    public class UserServices : IUserServices
    {
        private readonly ILogger<IUserServices> _logger;
        private readonly IUserRepository _userRepository;
        
        public UserServices(ILogger<IUserServices> logger,
                            IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        #region Get
        public User Get(int id)
        {
            try
            {
                return _userRepository.GetById(id);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter usuário");
                throw;
            }
            
        }
        #endregion
    }

    public interface IUserServices
    {
        User Get(int id);
    }
}
