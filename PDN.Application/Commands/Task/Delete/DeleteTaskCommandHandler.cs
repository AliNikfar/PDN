using MediatR;
using PDN.Application.StateSaver;
using PDN.Domain.Commands.Tasks;

namespace PDN.Application.Commands.Task.Delete
{
    public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand>
    {
        private readonly ITaskCommandRepo _taskCommandRepo ;
        private readonly IStateSaver _stateSaver ;

        public DeleteTaskCommandHandler(ITaskCommandRepo taskCommandRepo, IStateSaver stateSaver)
        {
            _taskCommandRepo = taskCommandRepo;
            _stateSaver = stateSaver;
        }

        public async System.Threading.Tasks.Task Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _taskCommandRepo.FindAsync(request.Id) ?? throw new ApplicationException();

            task.Delete();

            await _stateSaver.SaveChangeAsync();
        }
    }
}
