using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Application.DTOs;

namespace TaskApp.Application.Validators
{
    public class CreateTaskItemValidator : AbstractValidator<CreateTaskItemDto>
    {
        public CreateTaskItemValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required")
                .MaximumLength(100).WithMessage("Title must be up to 100 characters");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description must be up to 500 characters");

            RuleFor(x => x.DueDate)
                .GreaterThan(DateTime.UtcNow).When(x => x.DueDate.HasValue)
                .WithMessage("Due date must be in the future");
        }
    }
}
