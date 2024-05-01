using PDN.Domain.Entities.Projects;
using PDN.Shared.Abstraction.Commans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Domain.Commands.Projects
{
    public interface IProjectCommandRepo : ICommandRepo<Project, long>
    {
    }
}
