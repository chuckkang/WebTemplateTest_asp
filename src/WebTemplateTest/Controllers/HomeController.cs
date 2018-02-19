using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebTemplateTest.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebTemplateTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index()
        {
            UserModel newUser = new UserModel();
            return View(new UserModel { Name = "Chuck", UserId = 54321 });
        }

        public ActionResult ContactInfo() => View(new ContactInfoModel { Name = "Michelle", Address = "123 cielo" });

    }
}
