using MediatR;

namespace PDN.Application.Queries.Tasks.GetAll
{
    public record GetAllTaskQuery : IRequest<IEnumerable<GetAllTasksDTO>>
    {
    }
}