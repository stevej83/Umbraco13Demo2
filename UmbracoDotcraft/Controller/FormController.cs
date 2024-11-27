using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.Controllers;
using UmbracoDotcraft.BusinessLogic.Validation;
using UmbracoDotcraft.BusinessLogic.FormPeresistence;
using UmbracoDotcraft.Models;

namespace UmbracoDotcraft.Controller
{
    public class FormController : UmbracoApiController
    {
        private readonly IFormValidator _formValidator;
        private readonly IFormSaver _formSaver;

        public FormController(IFormValidator formValidator,
            IFormSaver formSaver)
        {
            _formValidator = formValidator;
            _formSaver = formSaver;
        }

        public FormResponse Submit(FormRequest request)
        {
            var errors = _formValidator.Validate(request);

            if (errors.Count == 0)
            {
                _formSaver.Save(request);
            }

            return new FormResponse
            {
                IsSuccess = errors.Count == 0,
                ErrorMessage = errors
            };
        }
    }
}
