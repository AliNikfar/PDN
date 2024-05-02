using Microsoft.EntityFrameworkCore;
using PDN.Domain.Commands.Tasks;
using PDN.Infrastructure.DBContexts;
using PDN.Infrastructure.Repo.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Infrastructure.Repo.Commands.Tasks
{
    public class TaskCommandRepo : CommandRepo<Domain.Entities.Tasks.Task, long>, ITaskCommandRepo
    {
        public TaskCommandRepo(PDNDBContext dbContext) : base(dbContext)
        {
        }
    }
}