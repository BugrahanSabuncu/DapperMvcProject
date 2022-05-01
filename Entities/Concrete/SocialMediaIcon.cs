using CV.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV.Entities.Concrete
{    
    public class SocialMediaIcon:ITable
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }

    }
}
