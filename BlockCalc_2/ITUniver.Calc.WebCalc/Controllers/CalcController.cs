using BlockCalc_2;
using ITUniver.Calc.DB.Models;
using ITUniver.Calc.DB.Repositories;
using System;
using System.Linq;
using System.Web.Mvc;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    [Authorize]
    public class CalcController : Controller
    {
        private IHistoryRepository HistoryRepository = new HistoryRepository();

        private IOperationRepository OperationRepository = new OperationRepository();

        // GET: Calc
        public ActionResult Index()
        {
            var calc = new My_Expression();

            var model = new OperationModel();

            model.Operations = calc.GetOpers().Select(
                o => new SelectListItem() {
                    Text = $"{o.Name}",
                    Value = $"{o.Name}"
                });

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(OperationModel model)
        {
            var calc = new My_Expression();

            model.Operations = calc.GetOpers().Select(o => new SelectListItem() { Text = $"{o.Name}", Value = $"{o.Name}" });

            model.Result = calc.Exec(model.Operation, model.Args.ToArray());

            #region Сохранение в HistoryRepository

            var item = new HistoryItem();
            item.Args = string.Join(" ", model.Args);
            item.Operation = 1;//oper;
            item.Result = model.Result;
            item.ExecDate = DateTime.Now;

            HistoryRepository.Save(item);

            #endregion

            return View(model);
        }

        // GET: Calc
        public ActionResult History()
        {
            var history = HistoryRepository.GetAll();
            return View(history);
        }
    }
}