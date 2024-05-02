﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Application.Queries.Projects.GetById
{
    public record GetProjectQuery : IRequest<GetProjectDTO>
    {
        public long Id { get; set; }
    }
}
