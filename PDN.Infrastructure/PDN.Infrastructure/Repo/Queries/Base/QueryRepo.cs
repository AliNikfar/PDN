using Microsoft.EntityFrameworkCore;
using PDN.Infrastructure.DBContexts;
using PDN.Shared.Abstraction.Queries;
using System.Linq.Expressions;


namespace PDN.Infrastructure.Repo.Queries.Base
{
    public class QueryRepo<TEntity> : IQueryRepo<TEntity>
        where TEntity : class
    {
        private readonly PDNDBContext _dbContext;
        private readonly IQueryable<TEntity> _querySet;

        public QueryRepo(PDNDBContext dbContext)
        {
            _dbContext = dbContext;
            _querySet = _dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity?> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return await _querySet.Where(predicate).FirstOrDefaultAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>>? predicate = null)
        {
            return await (predicate != null ? _querySet.Where(predicate) : _querySet).ToListAsync().ConfigureAwait(false);
        }
    }
}
