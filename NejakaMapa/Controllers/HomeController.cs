using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NejakaMapa.Models;
using System.Globalization;

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
            decimal lat = Decimal.Parse(data.Lat, CultureInfo.InvariantCulture);
            decimal lng = Decimal.Parse(data.Lng, CultureInfo.InvariantCulture);

            Udalosti.AddUdalost(lat, lng, data.Name, data.Date, data.Text);
            return true;
        }


    }
}