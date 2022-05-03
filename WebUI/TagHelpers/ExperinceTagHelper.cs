using CV.Business.Interfaces;
using CV.Entities.Concrete;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.TagHelpers
{
    [HtmlTargetElement("GetExperince")]
    public class ExperinceTagHelper : TagHelper
    {
        private readonly IGenericService<Experience> _genericService;

        public ExperinceTagHelper(IGenericService<Experience> genericService)
        {
            _genericService = genericService;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var experiences = _genericService.GetAll();
            string data = "<div class='d - flex flex - column flex - md - row justify - content - between mb - 5'> ";
            foreach (var item in experiences)
            {
                data += $@" <div class='flex - grow - 1'> 
                     <h3 class='mb-0'>{item.Title}</h3>
                    <div class='subheading mb-3'>{item.Subtitle}</div>
                    <p>{item.Description}</p>
                    </div>
                <div class='flex-shrink-0'> <span class='text-primary'>{item.StartDate} - {item.EndDate}</span> </div> ";
            }
            data += " </div>";
            output.Content.SetHtmlContent(data);
        }
    }
}
