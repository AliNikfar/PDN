using PDN.Domain.Entities.Projects;
using PDN.Domain.Queries.Projects;
using PDN.Infrastructure.DBContexts;
using PDN.Infrastructure.Repo.Queries.Base;

namespace PDN.Infrastructure.Repo.Queries.Projects
{
    public class ProjectQueryRepo: QueryRepo<Project>, IProjectQueryRepo
    {
        public ProjectQueryRepo(PDNDBContext dbContext) : base(dbContext)
        {
        }
    }
}
