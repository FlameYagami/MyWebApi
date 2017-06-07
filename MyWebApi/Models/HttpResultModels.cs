using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApi.Models
{
    public class HttpResultModels<T>
    {
        public int code { get; set; }

        public string reason { get; set; }
        public T result { get; set; }

        public HttpResultModels()
        {
            code = 200;
            reason = "Sicceed";
        }
    }
}