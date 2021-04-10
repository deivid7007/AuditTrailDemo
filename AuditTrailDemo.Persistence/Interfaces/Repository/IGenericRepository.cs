namespace AuditTrailDemo.Persistence.Interfaces.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IGenericRepository<TEntity> : IDisposable
        where TEntity : class
    {
        void Add(TEntity entity);

        IQueryable<TEntity> AsQueryable();

        void Update(TEntity entity);

        void UpdateRange(ICollection<TEntity> entities);

        void Remove(TEntity entity);

        int SaveChanges();

        Task<int> SaveChangesAsync();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
