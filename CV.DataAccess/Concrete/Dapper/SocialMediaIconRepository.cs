using CV.DataAccess.Abstract;
using CV.Entities.Concrete;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CV.DataAccess.Concrete.Dapper
{
    public class SocialMediaIconRepository :DpGenericRepository<SocialMediaIcon>, ISocialMediaIconRepository
    {
        private readonly IDbConnection _dbConnection;

        public SocialMediaIconRepository(IDbConnection dbConnection):base(dbConnection)
        {
            _dbConnection = dbConnection;
        }
        
        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _dbConnection.Query<SocialMediaIcon>("Select * from SocialMediaIcons where AppUserId=@id", new { id = userId }).ToList();
        }
    }
}
