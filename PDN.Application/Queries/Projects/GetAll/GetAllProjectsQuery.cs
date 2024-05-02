using MediatR;

namespace PDN.Application.Queries.Projects.GetAll
{
    public record GetAllProjectsQuery : IRequest<IEnumerable<GetAllProjectsDTO>>
    {
    }
}