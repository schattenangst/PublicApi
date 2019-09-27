namespace CourseWebApi.Persistence
{
    using CourseWebApi.Model.Context;
    using Microsoft.EntityFrameworkCore;

    public class BaseRepository
    {
        private readonly IRepositoryContext repositoryContext;

        public BaseRepository(IRepositoryContext respositoryContext)
        {
            this.repositoryContext = respositoryContext;
        }

        public DbContext Context
        {
            get
            {
                return repositoryContext as ApplicationDbContext;
            }
        }

    }
}
