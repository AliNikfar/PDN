using PDN.Shared.Abstraction.Commans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Domain.Commands.Tasks
{
    public interface ITaskCommandRepo : ICommandRepo<PDN.Domain.Entities.Tasks.Task, long>
    {
    }
}
