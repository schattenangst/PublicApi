
namespace CourseWebApi.Model.Context
{
    using System.Threading;
    using System.Threading.Tasks;

    public partial class ApplicationDbContext : IRepositoryContext
    {
        /// <summary>
        /// Save Changes
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            // OnBeforeSaving();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            // OnBeforeSaving();
            return base.SaveChangesAsync(cancellationToken);
        }

        /// <summary>
        /// Antes de guardar cambios a la base de datos se ejecuta este metodo
        /// </summary>
        private void OnBeforeSaving()
        {
            //foreach (var entity in ChangeTracker.Entries<IMedicAuditable>())
            //{
            //    if (entity.State == EntityState.Added ||
            //        entity.State == EntityState.Modified)
            //    {
            //        entity.Entity.ModificationDate = DateTime.UtcNow;
            //        entity.Entity.Active = entity.State != EntityState.Modified || entity.Entity.Active;
            //        entity.Entity.ModificationUser = "System";
            //    }
            //    else if (entity.State == EntityState.Deleted)
            //    {
            //        entity.State = EntityState.Modified;
            //        entity.Entity.ModificationDate = DateTime.Now;
            //        entity.Entity.Active = false;
            //        entity.Entity.ModificationUser = string.IsNullOrEmpty(user?.Email) ? entity.Entity.ModificationUser : "System";
            //    }
            //}
        }
    }
}