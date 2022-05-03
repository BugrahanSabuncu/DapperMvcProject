using AutoMapper;
using CV.Business.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.TagHelpers
{
    [HtmlTargetElement("GetIcons")]
    public class SocialMediaIconTagHelper : TagHelper
    {
        private readonly IUserService _userService;
        private readonly ISocialMediaIconService _iconService;
        private readonly IMapper _mapper;

        public SocialMediaIconTagHelper(IUserService userService, ISocialMediaIconService iconService, IMapper mapper)
        {
            _userService = userService;
            _iconService = iconService;
            _mapper = mapper;
        }

        public int AppUserId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var icons = _iconService.GetByUserId(AppUserId);
            string _data = "<div class='social - icons'> ";
            foreach (var item in icons)
            {
                _data += $@"<a class='social-icon pr-5' href='{item.Link}'><i class='{item.Icon}'></i></a> ";
                
            }
            _data += "</div>";
            output.Content.SetHtmlContent(_data);

        }
    }
}
