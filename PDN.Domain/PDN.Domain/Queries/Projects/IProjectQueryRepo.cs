using PDN.Domain.Entities.Projects;
using PDN.Shared.Abstraction.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Domain.Queries.Projects
{
    public interface IProjectQueryRepo : IQueryRepo<Project>
    {
    }
}
