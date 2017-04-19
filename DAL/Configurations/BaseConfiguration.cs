using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal abstract class BaseConfiguration<T> : EntityTypeConfiguration<T> where T : Base
    {
        public BaseConfiguration()
        {
            Property(x => x.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.DeletedAt)
                .HasColumnType("datetime2")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(x => x.InsertedAt)
                .HasColumnType("datetime2")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            }
        }
    
    internal abstract class BaseUpdateableConfiguration<T> : BaseConfiguration<T> where T : BaseUpdateable
    {
        public BaseUpdateableConfiguration()
        {
            Property(x => x.UpdatedAt)
                .HasColumnType("datetime2")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}
