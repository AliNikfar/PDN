using Microsoft.EntityFrameworkCore;
using PDN.Infrastructure.DBContexts;
using PDN.Shared.Abstraction.Commans;
using PDN.Shared.Abstraction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Infrastructure.Repo.Commands.Base
{
    public class CommandRepo<TEntity, TId> : ICommandRepo<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        protected readonly PDNDBContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public CommandRepo(PDNDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public async Task<TId> AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity).ConfigureAwait(false);

        return entity.Id;
    }

    public async Task<TEntity?> FindAsync(TId id)
    {
        return await _dbSet.FindAsync(id).ConfigureAwait(false);
    }
}
}
