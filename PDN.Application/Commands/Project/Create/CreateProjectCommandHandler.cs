using MediatR;
using PDN.Domain.Commands.Projects;
using PDN.Domain.Entities.Projects;
using PDN.Application.StateSaver;

namespace PDN.Application.Commands.Projects.Create
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, long>
    {
        private readonly IProjectCommandRepo _projectRepository ;
        private readonly IStateSaver _stateSaver ;

        public CreateProjectCommandHandler(IProjectCommandRepo projectRepository, IStateSaver stateSaver)
        {
            _projectRepository = projectRepository;
            _stateSaver = stateSaver;
        }

        public async Task<long> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = new Project(request.Title, request.Description, request.StartDate, request.EndDate);

            var projectId = await _projectRepository.AddAsync(project);

            await _stateSaver.SaveChangeAsync();

            return projectId;
        }
    }
}
