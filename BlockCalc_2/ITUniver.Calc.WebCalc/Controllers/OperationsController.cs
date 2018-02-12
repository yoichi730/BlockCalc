using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ITUniver.Calc.Core.Operation;
using System.Web.Mvc;
using ITUniver.Calc.WebCalc.Models;

namespace ITUniver.Calc.WebCalc.Controllers
{
    public class OperationsController : Controller
    {
        public ActionResult Index()
        {
            var oper = new _Operations();
            var args = new double[2] { 10, 30 };
            oper.Exec(args);

            return View(oper);
        }

        
    }
}
