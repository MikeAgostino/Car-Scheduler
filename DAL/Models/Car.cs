using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Car : BaseUpdateable
    {
        public string UserId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public int Mileage { get; set; }
        public string Vin { get; set; }
        public string Colour { get; set; }
    }
}
