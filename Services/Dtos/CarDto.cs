using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Dtos
{
    public class CarDto
    {
        public int Id { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int UserId {get ;set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicencePlate { get; set; }
        public string Mileage { get; set; }
        public string Vin { get; set; }
        public string colour { get; set; }
    }
}