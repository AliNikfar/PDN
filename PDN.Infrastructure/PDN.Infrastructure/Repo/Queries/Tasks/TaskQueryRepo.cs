
using PDN.Infrastructure.DBContexts;
using PDN.Infrastructure.Repo.Queries.Base;
using PDN.Domain.Queries.Tasks;

namespace PDN.Infrastructure.Repo.Queries.Tasks
{
    public class TaskQueryRepo: QueryRepo<Domain.Entities.Tasks.Task>, ITaskQueryRepo
    {
        public TaskQueryRepo(PDNDBContext dbContext) : base(dbContext)
        {
        }
    }
}
