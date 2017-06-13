using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NejakaMapa.Models
{
    public class Udalost
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Souradnice Pozice { get; set; }
        public DateTime Datum { get; set; }
        public string Poznamka { get; set; }
    }
}