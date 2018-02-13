using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlockCalc_2;

namespace WebCalc.Models
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(OperationModel model)
        {
            var calc = new My_Expression();

            model.AllOperations = calc.GetOperNames();

            model.Result = calc.Exec(model.Operation, model.Args.ToArray());

            return View(model);
        }
    }
}