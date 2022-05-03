using CV.Business.Interfaces;
using CV.DataAccess.Abstract;
using CV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV.Business.Concrete
{
    public class SocialMediaIconManager : GenericManager<SocialMediaIcon>, ISocialMediaIconService
    {
        private readonly IGenericRepository<SocialMediaIcon> _genericService;
        private readonly ISocialMediaIconRepository _socialMediaIconRepository;

        public SocialMediaIconManager(IGenericRepository<SocialMediaIcon> genericService, ISocialMediaIconRepository socialMediaIconRepository = null) : base(genericService)
        {
            _genericService = genericService;
            _socialMediaIconRepository = socialMediaIconRepository;
        }

        public List<SocialMediaIcon> GetByUserId(int userId)
        {
           return _socialMediaIconRepository.GetByUserId(userId);
        }
    }
}
