using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class CustomerValidator:AbstractValidator<Customer>
	{
		public CustomerValidator()
		{
			RuleFor(c2=>c2.UserId).NotEmpty();
		}
	}
}

