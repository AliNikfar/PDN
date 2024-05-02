using MediatR;
using PDN.Application.StateSaver;
using PDN.Domain.Commands.Tasks;
using PDN.Domain.Queries.Projects;

namespace PDN.Application.Commands.Task.Create
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, long>
    {
        private readonly ITaskCommandRepo _taskCommandRepo ;
        private readonly IProjectQueryRepo _projectQueryRepo ;
        private readonly IStateSaver _stateSaver ;

        public CreateTaskCommandHandler(ITaskCommandRepo taskCommandRepo, IProjectQueryRepo projectQueryRepo, IStateSaver stateSaver)
        {
            _taskCommandRepo = taskCommandRepo;
            _projectQueryRepo = projectQueryRepo;
            _stateSaver = stateSaver;
        }

        public async Task<long> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectQueryRepo.Get(i => i.Id == request.ProjectId) ?? throw new ApplicationException();

            var task = new Domain.Entities.Tasks.Task(request.Title, request.Description, request.DueDate, request.Status, project.Id);

            await _taskCommandRepo.AddAsync(task);

            await _stateSaver.SaveChangeAsync();

            return task.Id;
        }
    }
}
