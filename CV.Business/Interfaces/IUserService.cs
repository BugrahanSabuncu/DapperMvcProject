using CV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV.Business.Interfaces
{
    public interface IUserService:IGenericService<User>
    {
        /// <summary>
        ///  User var ise true döner yok ise false döner.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CheckUser(string userName, string password);
    }
}
