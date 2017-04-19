using System;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;



namespace DAL.Contexts
{

    class ColumnNameConvention : IStoreModelConvention<EdmProperty>
    {
        public void Apply(EdmProperty property, DbModel model)
        {
            /**
             * Steps:
             * - [A-Z] -> _[A-Z]
             * - lowercase all
             * - strip first underscore
             */
            //property.Name = System.Data.Entity.ModelConfiguration.Conventions.Convention
        }
    }

    public abstract class BaseContext : DbContext
    {

        static BaseContext()
        {
            Database.SetInitializer<BaseContext>(null);
        }

        protected BaseContext() : base("name=DBConnection")
        {
            //LazyLoading enabled
            //ProxyCreation enabled
        }

        //Persistance
        public override int SaveChanges()
        {
           // RefreshUpdatedAt();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        //private void RefreshUpdatedAt()
        //{
        //    var entities = ChangeTracker.Entries().Where(x => (x.Entity is IBase || x.Entity is IUpdateable) && (x.))
        //}


        //Wire up the DB conventions
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new ColumnNameConvention());
        }

        public void SetModified(Object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
