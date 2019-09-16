using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlog.BLL.Interfaces;

namespace MyBlog.UI.Controllers
{
    public class AccountController : Controller
    {
        IUserServices _userService;

        public AccountController(IUserServices userService)
        {
            _userService = userService;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}