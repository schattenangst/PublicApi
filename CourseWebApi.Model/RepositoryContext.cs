
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
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}