using CV.DataAccess.Abstract;
using CV.Entities.Concrete;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CV.DataAccess.Concrete.Dapper
{
    public class AppUserRepository:DpGenericRepository<User>,IAppUserRepository
    {
        private readonly IDbConnection _dbConnection;
        public AppUserRepository(IDbConnection dbConnection):base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public bool CheckUser(string username, string password)
        {
            var user=_dbConnection.QueryFirstOrDefault("select * from AppUsers where userName=@username and Password=@password", new
            {
                username = username,
                password = password
            });
            return user != null;
        }

        public User FindByName(string userName)
        {
            var user = _dbConnection.QueryFirstOrDefault<User>("select * from AppUsers where UserName=@username", new
            { username = userName });
            return user;
        }
    }
}
