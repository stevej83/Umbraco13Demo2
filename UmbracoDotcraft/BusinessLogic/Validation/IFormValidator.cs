using UmbracoDotcraft.Models;

namespace UmbracoDotcraft.BusinessLogic.Validation
{
    public interface IFormValidator
    {
        public List<string> Validate(FormRequest request);
    }
}
