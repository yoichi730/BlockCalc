using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCalc.Models;

namespace ITUniver.Calc.WebCalc.Controllers
{
    public class AccauntController : Controller
    {
        private IUserRepository Users { get; set; }

        // GET: Accaunt
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid) return View();

            if (true)
            {

            }
            
            return View()
        }

        // GET: Accaunt
        public void Logout()
        {
            
        }
    }
}