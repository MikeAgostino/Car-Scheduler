using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Dtos
{
    public class ModelResponse<T> where T: class
    {
        public ErrorResponse Error { get; set; }
        public T Model { get; set; }
    }
}