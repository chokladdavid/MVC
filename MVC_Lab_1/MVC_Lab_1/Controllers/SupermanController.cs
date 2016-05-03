using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Lab_1.Controllers
{
    public class SupermanController : Controller
    {
        // GET: Superman
        public ActionResult DoGood(string id = "0")
        {
            //List<string> quoteList = new List<string>(){"I Do Good!","Dudududduuu!","For Justice!"};
            //int trueId;
            //bool idIsint = int.TryParse(id, out trueId);
            //if (quoteList[trueId] != null)
            //    return View(quoteList[trueId]);
            //return View($"Only {quoteList.Count}st quotes exist!");
            ViewBag.IdIn = id;
            return View();
        }
    }
}