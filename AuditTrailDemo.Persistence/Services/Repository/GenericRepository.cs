namespace AuditTrailDemo.Persistence.Services.Repository
{
    using AuditTrailDemo.Persistence.Interfaces.Repository;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        private readonly DbContext context;
        private readonly DbSet<TEntity> set;

        public GenericRepository(DbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.set = this.context.Set<TEntity>();
        }

        public void Add(TEntity entity) => this.set.Add(entity);

        public async Task AddAsync(TEntity entity) => await this.set.AddAsync(entity);

        public IQueryable<TEntity> AsQueryable() => this.set;

        public void Remove(TEntity entity) => this.set.Remove(entity);

        public int SaveChanges() => this.context.SaveChanges();

        public async Task<int> SaveChangesAsync() => await this.context.SaveChangesAsync();

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) => await this.context.SaveChangesAsync(cancellationToken);

        public void Update(TEntity entity) => this.set.Update(entity);

        public void UpdateRange(ICollection<TEntity> entities) => this.set.UpdateRange(entities);

        public void Dispose()
        {
            this.context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
