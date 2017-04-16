using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Services.Dtos
{
    public class ErrorResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
    }
}