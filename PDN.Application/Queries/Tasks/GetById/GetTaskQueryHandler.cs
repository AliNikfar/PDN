using MediatR;
using PDN.Domain.Queries.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Application.Queries.Tasks.GetById
{
    public class GetTaskQueryHandler: IRequestHandler<GetTaskQuery, GetTaskDTO>
    {
        private readonly IProjectQueryRepo _projectQueryRepo ;

        public GetTaskQueryHandler(IProjectQueryRepo projectQueryRepo)
        {
            _projectQueryRepo = projectQueryRepo;
        }

        public async Task<GetTaskDTO> Handle(GetTaskQuery request, CancellationToken cancellationToken)
    {
        var project = await _projectQueryRepo.Get(i => i.Id == request.Id && i.IsDeleted == false) ?? throw new ApplicationException();

        return new GetTaskDTO
        {
            Title = project.Title,
            Description = project.Description,
            StartDate = project.StartDate,
            EndDate = project.EndDate
        };
    }
}
}
