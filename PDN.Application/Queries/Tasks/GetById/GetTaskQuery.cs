using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Application.Queries.Tasks.GetById
{
    public record GetTaskQuery : IRequest<GetTaskDTO>
    {
        public long Id { get; set; }
    }
}
