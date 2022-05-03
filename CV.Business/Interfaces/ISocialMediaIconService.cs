using CV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV.Business.Interfaces
{
    public interface ISocialMediaIconService:IGenericService<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int userId);
    }
}
