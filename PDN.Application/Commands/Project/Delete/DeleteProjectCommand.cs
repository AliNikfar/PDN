using MediatR;

namespace PDN.Application.Commands.Projects.Delete
{
    public record DeleteProjectCommand : IRequest
    {
        public long Id { get; set; }
    }
}
