using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNet5MVCApp1.Models;

namespace WebNet5MVCApp1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Logon()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logon(LoginViewModel loginData)
        {
            if(ModelState.IsValid)
            {
                string userId = loginData.UserId;

            }
            

            return View();
        }
    }
}
