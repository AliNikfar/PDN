using MediatR;
using PDN.Domain.Queries.Tasks;

namespace PDN.Application.Queries.Tasks.GetById
{
    public class GetTaskQueryHandler: IRequestHandler<GetTaskQuery, GetTaskDTO>
    {
        private readonly ITaskQueryRepo _taskQueryRepo;

        public GetTaskQueryHandler(ITaskQueryRepo taskQueryRepo)
        {
            _taskQueryRepo = taskQueryRepo;
        }

        public async Task<GetTaskDTO> Handle(GetTaskQuery request, CancellationToken cancellationToken)
        {
            var task = await _taskQueryRepo.Get(i => i.Id == request.Id && i.IsDeleted == false) ?? throw new ApplicationException();

            return new GetTaskDTO
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
                DueDate = task.DueDate,
                ProjectId = task.ProjectId,
                Status = task.Status
            };
        }
    }
}

