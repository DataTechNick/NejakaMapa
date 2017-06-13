using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace NejakaMapa.Models
{
    public static class JSONUtils
    {

        public static string ToJSON(this object obj) {

            return JsonConvert.SerializeObject(obj);

        }

    }
}