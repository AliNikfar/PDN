#nullable disable
using MediatR;


namespace PDN.Application.Commands.Task.Create
{
    public record CreateTaskCommand : IRequest<long>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public TaskStatus Status { get; set; }

        public long ProjectId { get; set; }
    }
}
