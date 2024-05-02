#nullable disable
using MediatR;

namespace PDN.Application.Commands.Projects.Update
{
    public record UpdateProjectCommand : IRequest<long>
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
