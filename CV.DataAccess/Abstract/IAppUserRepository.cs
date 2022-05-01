using CV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV.DataAccess.Abstract
{
    public interface IAppUserRepository:IGenericRepository<User>
    {
        bool CheckUser(string username, string password);
    }
}
