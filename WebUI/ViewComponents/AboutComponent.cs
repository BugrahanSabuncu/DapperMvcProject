using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.AppUserDtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class AboutComponent:ViewComponent
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public AboutComponent(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {           
            return View(_mapper.Map<AppUserListDto>(_userService.GetById(1)));
        }
    }
}
