

using MediatR;
using PDN.Application.StateSaver;
using PDN.Domain.Commands.Projects;

namespace PDN.Application.Commands.Projects.Update
{
    public class UpdateTeamCommandHandler: IRequestHandler<UpdateProjectCommand, long>
    {
        private readonly IProjectCommandRepo _projectRepo;
        private readonly IStateSaver _stateSaver ;

        public async System.Threading.Tasks.Task<long> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepo.FindAsync(request.Id) ?? throw new ApplicationException();

            project.Update(request.Title, request.Description, request.StartDate, request.EndDate);

            await _stateSaver.SaveChangeAsync();

            return project.Id;
        }
    }
}
