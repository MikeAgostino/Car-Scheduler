using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public abstract class Base : IBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime InsertedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }

    public abstract class BaseUpdateable :Base
    {
        public DateTime? UpdatedAt { get; set; }
    }
}
