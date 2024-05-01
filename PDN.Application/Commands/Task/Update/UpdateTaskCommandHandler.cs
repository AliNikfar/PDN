using MediatR;
using PDN.Application.StateSaver;
using PDN.Domain.Commands.Tasks;

namespace PDN.Application.Commands.Task.Update
{
    public class UpdateTaskCommandHandler: IRequestHandler<UpdateTaskCommand, long>
    {
        private readonly ITaskCommandRepo _taskCommandRepo ;
        private readonly IStateSaver _unitOfWork ;

        public UpdateTaskCommandHandler(ITaskCommandRepo taskCommandRepo, IStateSaver unitOfWork)
        {
            _taskCommandRepo = taskCommandRepo;
            _unitOfWork = unitOfWork;
        }

        public async Task<long> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _taskCommandRepo.FindAsync(request.Id) ?? throw new ApplicationException();

            task.Update(request.Title, request.Description, request.DueDate, request.Status);

            await _unitOfWork.SaveChangeAsync();

            return task.Id;
        }
    }
}
