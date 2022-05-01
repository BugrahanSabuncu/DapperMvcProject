using CV.Business.Interfaces;
using CV.DataAccess.Abstract;
using CV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV.Business.Concrete
{
    public class UserManager : GenericManager<User>,IUserService
    {
        private readonly IGenericRepository<User> _genericRepository;
        private readonly IAppUserRepository _userRepository;

        public UserManager(IGenericRepository<User> genericRepository, IAppUserRepository userRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
            _userRepository = userRepository;
        }

        public bool CheckUser(string userName, string password)
        {            
            return _userRepository.CheckUser(userName, password);
        }

        public User FindByName(string userName)
        {
            return _userRepository.FindByName(userName);
        }
    }
}
