using AutoMapper;
using MediatR;
using PDN.Domain.Queries.Tasks;

namespace PDN.Application.Queries.Tasks.GetById
{
    public class GetTaskQueryHandler: IRequestHandler<GetTaskQuery, GetTaskDTO>
    {
        private readonly ITaskQueryRepo _taskQueryRepo;
        private readonly IMapper _mapper;

        public GetTaskQueryHandler(ITaskQueryRepo taskQueryRepo)
        {
            _taskQueryRepo = taskQueryRepo;
        }

        public async Task<GetTaskDTO> Handle(GetTaskQuery request, CancellationToken cancellationToken)
        {
            var task = await _taskQueryRepo.Get(i => i.Id == request.Id && i.IsDeleted == false) ?? throw new ApplicationException();
            var result = _mapper.Map<GetTaskDTO>(task);
            return result;
        }
    }
}

