using FluentValidation;

namespace PDN.Application.Commands.Projects.Delete
{
    public class DeleteTeamCommandValidator : AbstractValidator<DeleteProjectCommand>
    {
        public DeleteTeamCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().NotNull();
        }
    }
}
