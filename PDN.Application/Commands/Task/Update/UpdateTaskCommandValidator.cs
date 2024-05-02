using FluentValidation;

namespace PDN.Application.Commands.Task.Update
{
    public class UpdateTaskCommandValidator : AbstractValidator<UpdateTaskCommand>
    {
        public UpdateTaskCommandValidator()
        {
            RuleFor(p => p.Id).NotNull().NotEmpty();
            RuleFor(p => p.Title).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(p => p.Description).MaximumLength(250);
            RuleFor(p => p.DueDate).NotNull().NotEmpty();
            RuleFor(p => p.Status).NotEmpty().NotNull();
        }
    }
}
