using Microsoft.EntityFrameworkCore;
using PDN.Domain.Commands.Projects;
using PDN.Domain.Entities.Projects;
using PDN.Infrastructure.DBContexts;
using PDN.Infrastructure.Repo.Commands.Base;


namespace PDN.Infrastructure.Repo.Commands.Projects
{
    public class ProjectCommandRepo : CommandRepo<Project, long>, IProjectCommandRepo
    {
        public ProjectCommandRepo(PDNDBContext dbContext) : base(dbContext)
        {
        }
    }
}
