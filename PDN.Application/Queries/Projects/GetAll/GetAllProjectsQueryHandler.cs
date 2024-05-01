using MediatR;
using PDN.Domain.Queries.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Application.Queries.Projects.GetAll
{
    public class GetAllProjectsQueryHandler : IRequestHandler<GetAllProjectsQuery, IEnumerable<GetAllProjectsDTO>>
    {
        private readonly IProjectQueryRepo _projectsQueryRepo;
        public GetAllProjectsQueryHandler(IProjectQueryRepo projectQueryRepo) 
        {
            _projectsQueryRepo = projectQueryRepo;
        }

        public async Task<IEnumerable<GetAllProjectsDTO>> Handle(GetAllProjectsQuery request, CancellationToken cancellationToken)
        {
            var projects = await _projectsQueryRepo.GetAll(i => i.IsDeleted == false);

            return from project in projects
                   select new GetAllProjectsDTO()
                   {
                       Id = project.Id,
                       Description = project.Description,
                       Title = project.Title,
                       StartDate = project.StartDate,
                       EndDate = project.EndDate
                   };
        }
    }
}

