using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NejakaMapa.Models
{
    public class JsonData
    {
        public string Name { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}