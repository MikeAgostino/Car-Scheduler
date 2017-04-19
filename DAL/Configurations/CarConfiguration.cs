using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class CarConfiguration : BaseUpdateableConfiguration<Car>
    {
        public CarConfiguration()
        {
            ToTable("cars");
        }
    }
}
