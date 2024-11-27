using UmbracoDotcraft.Models;

namespace UmbracoDotcraft.BusinessLogic.FormPeresistence
{
    public interface IFormSaver
    {
        void Save(FormRequest request);
    }
}
