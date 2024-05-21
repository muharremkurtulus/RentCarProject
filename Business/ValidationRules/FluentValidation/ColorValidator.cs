using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class ColorValidator:AbstractValidator<Color>
	{
		public ColorValidator()
		{
			RuleFor(c1 => c1.Name).NotEmpty();
		}
	}
}

