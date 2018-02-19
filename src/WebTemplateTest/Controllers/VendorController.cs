using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebTemplateTest.Models;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebTemplateTest.Controllers
{
    public class VendorController : Controller
    {
        // GET: /<controller>/
        public VendorModel newVendor = new VendorModel { Name = "ABC Business", Address = "9876 Union" };
        public IActionResult Index()
        {
            return View(newVendor);
        }

        public IActionResult EditVendor() => View(newVendor);

    }
}
