using UmbracoDotcraft.Models;

namespace UmbracoDotcraft.BusinessLogic.FormPeresistence
{
    public class FormSaver : IFormSaver
    {
        public void Save(FormRequest request)
        {
            var filePath = Path.Join(Environment.CurrentDirectory, "FormSubmissions.txt");
            File.AppendAllText(filePath, $"{DateTime.UtcNow.ToString("yyyyMMdd HHmmss")},{request.Name},{request.Email},{request.DOB.ToString("yyyyMMdd")}\r\n");
        }
    }
}
