using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarpetPitch.Business.Abstract;
using CarpetPitch.Entity.Concrete;
using CarpetPitch.MvcWebUI.Models;

namespace CarpetPitch.MvcWebUI.Controllers
{
    public class CarpetPitchController : Controller
    {
        private readonly IUsersService _usersService;

        public CarpetPitchController(IUsersService usersService)
        {
            _usersService = usersService;
        }
        public IActionResult GetCarpetPitches()
        {
            var user = new User() {FirstName = "gg"};
            {
                _usersService.Add(user);
            };

            var model = new userListViewModel
            {
                Users = _usersService.GetList()
            };
            return View(model);
        }

        
    }
}
