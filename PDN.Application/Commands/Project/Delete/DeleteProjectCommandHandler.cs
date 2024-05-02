

using MediatR;
using PDN.Application.StateSaver;
using PDN.Domain.Commands.Projects;

namespace PDN.Application.Commands.Projects.Delete
{
    public class DeleteProjectCommandHandler: IRequestHandler<DeleteProjectCommand>
    {
        private readonly IProjectCommandRepo _projectRepo ;
        private readonly IStateSaver _stateSaver ;

        public DeleteProjectCommandHandler(IProjectCommandRepo projectRepo, IStateSaver unitOfWork)
        {
            _projectRepo = projectRepo;
            _stateSaver = unitOfWork;
        }

        public async System.Threading.Tasks.Task Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepo.FindAsync(request.Id) ?? throw new ApplicationException();
            
            project.Delete();

            await _stateSaver.SaveChangeAsync();
        }
    }
}
