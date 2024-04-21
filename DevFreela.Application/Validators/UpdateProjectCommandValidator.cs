using DevFreela.Application.Commands.UpdateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        public UpdateProjectCommandValidator()
        {
            RuleFor(p => p.Title)
               .MaximumLength(30)
               .NotEmpty()
               .WithMessage("Título deve ter no maximo 30 caracteres");

            RuleFor(p => p.Description)
                    .MaximumLength(255)
                    .NotEmpty()
                    .WithMessage("Descrição deve ter no maximo 255 caracteres");
        }
    }
}