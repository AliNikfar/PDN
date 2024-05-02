using MediatR;

namespace PDN.Application.Commands.Task.Delete
{
    public record DeleteTaskCommand : IRequest
    {
        public long Id { get; set; }
    }
}
    