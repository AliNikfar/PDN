using PDN.Shared.Abstraction.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDN.Domain.Entities.Tasks;
using Task = PDN.Domain.Entities.Tasks.Task;

namespace PDN.Domain.Queries.Tasks
{
    public interface ITaskQueryRepo : IQueryRepo<Task>
    {

    }
}
