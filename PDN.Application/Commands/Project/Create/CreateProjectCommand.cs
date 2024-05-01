#nullable disable
using MediatR;

namespace PDN.Application.Commands.Projects.Create
{
    public record CreateProjectCommand : IRequest<long>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
