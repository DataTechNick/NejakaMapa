﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NejakaMapa.Models
{
    public class Souradnice
    {
        public Guid Id { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
    }
}