using MediatR;
using PDN.Domain.Queries.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Application.Queries.Tasks.GetAll
{
    public class GetAllTaskQueryHandler : IRequestHandler<GetAllTaskQuery, IEnumerable<GetAllTasksDTO>>
    {
        private readonly ITaskQueryRepo _taskQueryRepo;

        public GetAllTaskQueryHandler(ITaskQueryRepo taskQueryRepo)
        {
            _taskQueryRepo = taskQueryRepo;
        }

        public async Task<IEnumerable<GetAllTasksDTO>> Handle(GetAllTaskQuery request, CancellationToken cancellationToken)
        {
            var tasks = await _taskQueryRepo.GetAll(i => i.IsDeleted == false);

            return from task in tasks
                   select new GetAllTasksDTO()
                   {
                       Id = task.Id,
                       Description = task.Description,
                       Title = task.Title,
                       DueDate = task.DueDate,
                       ProjectId = task.ProjectId,
                       Status = task.Status
                   };
        }
    }
}

