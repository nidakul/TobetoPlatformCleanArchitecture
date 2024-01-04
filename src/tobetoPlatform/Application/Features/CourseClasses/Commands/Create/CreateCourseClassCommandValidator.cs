using FluentValidation;

namespace Application.Features.CourseClasses.Commands.Create;

public class CreateCourseClassCommandValidator : AbstractValidator<CreateCourseClassCommand>
{
    public CreateCourseClassCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
    }
}