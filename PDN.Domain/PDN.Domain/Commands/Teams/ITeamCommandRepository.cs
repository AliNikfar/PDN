using PDN.Domain.Entities.Teams;
using PDN.Shared.Abstraction.Commans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Domain.Commands.Teams
{
    public interface ITeamCommandRepo : ICommandRepo<Team, long>
    {
    }
}
