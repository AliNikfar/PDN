using PDN.Domain.Entities.Teams;
using PDN.Shared.Abstraction.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Domain.Queries.Teams
{
    public interface ITeamQueryRepo : IQueryRepo<Team>
    {
    }
}
