using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NejakaMapa.Models;

namespace NejakaMapa.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View(Udalosti.GetUdalosti());
        }

        public ActionResult Points()
        {
            return View(Udalosti.GetUdalosti());
        }

        public bool Ajax(JsonData data)
        {
            Udalosti.AddUdalost(data.Lat, data.Lng, data.Name, data.Date, data.Text);
            return true;
        }


    }
}