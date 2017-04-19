using DAL.Configurations;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contexts
{
    public class WSContext : BaseContext
    {
        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new ColumnNameConvention());
            modelBuilder.Configurations.Add(new CarConfiguration());
        }
    }
}
