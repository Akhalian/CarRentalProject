using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();
            //RuleFor(u => u.Password).NotEmpty();
            //RuleFor(u => u.Password).MinimumLength(8);
            //RuleFor(u => u.Password).Must(HaveACapitalLetter);
            //RuleFor(u => u.Password).Must(HaveALowerLetter);
            //RuleFor(u => u.Password).Must(HaveANumber);
        }

        private bool HaveANumber(string arg)
        {
            foreach (char c in arg)
            {
                if (char.IsNumber(c) == true)
                {
                    return true;
                }
            }
            return false;
        }

        private bool HaveALowerLetter(string arg)
        {
            foreach (char c in arg)
            {
                if (char.IsLower(c) == true)
                {
                    return true;
                }
            }
            return false;
        }

        private bool HaveACapitalLetter(string arg)
        {
            foreach (char c in arg)
            {
                if (char.IsUpper(c)==true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
