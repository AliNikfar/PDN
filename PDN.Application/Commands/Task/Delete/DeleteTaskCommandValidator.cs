using FluentValidation;

namespace PDN.Application.Commands.Task.Delete
{
    public class DeleteTaskCommandValidator : AbstractValidator<DeleteTaskCommand>
    {
        public DeleteTaskCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().NotNull();
        }
    }
}
