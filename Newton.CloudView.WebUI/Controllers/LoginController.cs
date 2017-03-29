using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Newton.CloudView.WebUI.Controllers
{
    public class LoginController : CloudViewController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}