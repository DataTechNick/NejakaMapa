using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NejakaMapa.Models
{
    public static class Udalosti
    {
        private static List<Udalost> udalosti = new List<Udalost>();


        public static void AddUdalost(float lat, float lng, string name, DateTime date, string text) {

            Udalost udalost = new Udalost();
            Souradnice souradnice = new Souradnice();

            souradnice.Lat = lat;
            souradnice.Lng = lng;

            udalost.Pozice = souradnice;
            udalost.Datum = date;
            udalost.Poznamka = text;

            udalosti.Add(udalost);

        }

        public static IList<Udalost> GetUdalosti()
        {
            return udalosti;
        }

    }
}