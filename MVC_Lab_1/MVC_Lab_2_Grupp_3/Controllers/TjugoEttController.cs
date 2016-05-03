using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MVC_Lab_2_Grupp_3.Models;

namespace MVC_Lab_2_Grupp_3.Controllers
{
    public class TjugoEttController : Controller
    {
        // GET: TjugoEtt
        public ActionResult Play()
        {
            ViewBag.result = string.Empty;
            // ViewBag.choice = 0;
            TjugoEttModels.CurrentNumber = 0;
            TjugoEttModels.SetStartPlayer();
            return View();
        }

        [HttpPost]
        public ActionResult Play(string buttonValue)
        {
            int choise = int.Parse(Request["choice"]);
            TjugoEttModels.CurrentNumber += choise;
            ViewBag.result = TjugoEttModels.HandleGameResults();
            return View();
        }
    }
}