using System.Text.RegularExpressions;
using UmbracoDotcraft.Models;

namespace UmbracoDotcraft.BusinessLogic.Validation
{
    public class FormValidator : IFormValidator
    {
        public List<string> Validate(FormRequest request)
        {
            var errors = new List<string>();

            if (string.IsNullOrEmpty(request.Name))
            {
                errors.Add("Please enter your name");
            }

            if (string.IsNullOrEmpty(request.Email))
            {
                errors.Add("Please enter your email");
            }
            else
            {
                var emailRegex = new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");
                if (!emailRegex.IsMatch(request.Email))
                {
                    errors.Add("Please enter a valid email address");
                }
            }

            if (request.DOB > DateTime.Now)
            {
                errors.Add("Date of birth cannot be in the future");
            }

            return errors;
        }
    }
}
