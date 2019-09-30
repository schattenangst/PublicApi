
namespace CourseWebApi.Persistence
{
    using CourseWebApi.Common.Contracts.IPersistence;
    using CourseWebApi.Model.Context;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BasePersistence<T> : IBasePersistence<T> where T : class
    {

        protected readonly IRepositoryContext context;

        public BasePersistence(IRepositoryContext context)
        {
            this.context = context;
        }

        public DbContext Context
        {
            get
            {
                return context as ApplicationDbContext;
            }
        }

        public Task<int> Count(System.Linq.Expressions.Expression<Func<T, bool>> filtro, params System.Linq.Expressions.Expression<Func<T, object>>[] propiedadesNavegacion)
        {
            throw new NotImplementedException();
        }

        public Task<T> Create(T entidad)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Create(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<T> Edit(T entidad)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> FindAsync(System.Linq.Expressions.Expression<Func<T, bool>> filtro, params System.Linq.Expressions.Expression<Func<T, object>>[] propiedadesNavegacion)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<T>> FindAllAsync()
        {
            IQueryable<T> query = GetQuerable();

            return await query.ToListAsync();
        }

        public Task<IList<T>> FindAllAsync(System.Linq.Expressions.Expression<Func<T, bool>> filter = null, params System.Linq.Expressions.Expression<Func<T, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> FindAllAsync(System.Linq.Expressions.Expression<Func<T, bool>>[] filters = null, params System.Linq.Expressions.Expression<Func<T, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindFirstAsync(System.Linq.Expressions.Expression<Func<T, bool>> filtro, params System.Linq.Expressions.Expression<Func<T, object>>[] propiedadesNavegacion)
        {
            throw new NotImplementedException();
        }

        public Task<int> Remove(T entidad)
        {
            throw new NotImplementedException();
        }

        private IQueryable<T> GetQuerable()
        {
            return Context.Set<T>();
        }
    }
}
