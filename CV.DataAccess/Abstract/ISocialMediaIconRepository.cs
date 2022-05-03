using CV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV.DataAccess.Abstract
{
    public interface ISocialMediaIconRepository:IGenericRepository<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int userId);
    }
}
