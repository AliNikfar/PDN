using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Shared.Abstraction.Queries
{
    public interface IQueryRepo<T>
    {
        Task<T?> Get(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? predicate);
    }
}
