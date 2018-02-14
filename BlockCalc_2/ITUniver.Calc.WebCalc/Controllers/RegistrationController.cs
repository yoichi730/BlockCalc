using ITUniver.Calc.DB.Models;
using System.Web.Mvc;
using System.Web.Security;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    public class RegistrationController : Controller
    {

        public RegistrationController()
        {
                
        }

        [AllowAnonymous]
        public ActionResult Reg()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Reg(RegistrationModel model)
        {

            if (!ModelState.IsValid)
                return View();            

            var NewUser = new User();
            NewUser.BirthDay = model.BirthDay;
            NewUser.Login = model.Login;
            NewUser.Name = model.UserName;
            NewUser.Password = model.Password;
            NewUser.Sex = model.Sex;

            // регистрауция нового пользователя в DB
            return RedirectToAction("Login", "Account");
        }
        
    }
}
