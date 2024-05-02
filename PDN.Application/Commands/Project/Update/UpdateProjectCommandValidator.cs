using FluentValidation;

namespace PDN.Application.Commands.Projects.Update
{
    public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        public UpdateProjectCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().NotNull();
            RuleFor(p => p.Title).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(p => p.Description).MaximumLength(250);
            RuleFor(p => p.StartDate).NotEmpty().NotNull();
        }
    }
}
