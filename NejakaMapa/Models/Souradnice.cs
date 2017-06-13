using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NejakaMapa.Models
{
    public class Souradnice
    {
        public Guid Id { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
    }
}