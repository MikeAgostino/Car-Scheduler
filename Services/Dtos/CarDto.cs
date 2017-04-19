using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Dtos
{
    public class CarDto
    {
        public int Id { get; set; }
        public int UserId {get ;set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicencePlate { get; set; }
        public string Mileage { get; set; }
        public string VIN { get; set; }
        public string colour { get; set; }
    }
}