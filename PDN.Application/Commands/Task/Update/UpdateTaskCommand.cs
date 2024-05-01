#nullable disable
using MediatR;


namespace PDN.Application.Commands.Task.Update
{
    public class UpdateTaskCommand : IRequest<long>
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public TaskStatus Status { get; set; }
    }
}
