﻿using System;
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
            TjugoEttModels.CurrentNumber = 0;
            TjugoEttModels.SetStartPlayer();
            return View();
        }
        public string NextTurn(int buttonValue)
        {
            TjugoEttModels.CurrentNumber += buttonValue;
            return TjugoEttModels.HandleGameResults();
        }
    }
}