using MediatR;
using PDN.Domain.Queries.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Application.Queries.Projects.GetById
{
    public class GetProjectQueryHandler : IRequestHandler<GetProjectQuery, GetProjectDTO>
    {
        private readonly IProjectQueryRepo _projectQueryRepo ;

        public GetProjectQueryHandler(IProjectQueryRepo projectQueryRepo)
        {
            _projectQueryRepo = projectQueryRepo;
        }

        public async Task<GetProjectDTO> Handle(GetProjectQuery request, CancellationToken cancellationToken)
    {
        var project = await _projectQueryRepo.Get(i => i.Id == request.Id && i.IsDeleted == false) ?? throw new ApplicationException();

        return new GetProjectDTO
        {
            Title = project.Title,
            Description = project.Description,
            StartDate = project.StartDate,
            EndDate = project.EndDate
        };
    }
}
}
