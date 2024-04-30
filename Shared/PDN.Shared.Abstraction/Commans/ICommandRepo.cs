using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Shared.Abstraction.Commans
{
    public interface ICommandRepo<T, TID>
    {
        Task<T?> FindAsync(TID id);

        Task<TID> AddAsync(T entity);
    }
}
