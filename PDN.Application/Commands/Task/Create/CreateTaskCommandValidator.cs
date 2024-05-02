using FluentValidation;

namespace PDN.Application.Commands.Task.Create
{
    public class CreateTaskCommandValidator : AbstractValidator<CreateTaskCommand>
    {
        public CreateTaskCommandValidator()
        {
            RuleFor(p => p.Title).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(p => p.Description).MaximumLength(250);
            RuleFor(p => p.DueDate).NotNull().NotEmpty();
            RuleFor(p => p.ProjectId).NotEmpty().NotNull();
        }
    }
}
