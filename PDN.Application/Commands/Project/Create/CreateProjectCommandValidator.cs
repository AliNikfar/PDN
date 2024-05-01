using FluentValidation;


namespace PDN.Application.Commands.Projects.Create
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(p => p.Title).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(p => p.Description).MaximumLength(250);
            RuleFor(p => p.StartDate).NotEmpty().NotNull().GreaterThan(DateTime.Now);
        }
    }
}
