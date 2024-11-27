using UmbracoDotcraft.BusinessLogic.Validation;
using UmbracoDotcraft.Models;

namespace UmbracoDotcraft.Tests
{
    public class FormValidatorTests
    {
        private FormValidator validator;

        public FormValidatorTests()
        {
            validator = new FormValidator();
        }

        [Fact]
        public void TestNameRequired()
        {
            // Arrange
            var request = new FormRequest
            {
                Name = null
            };

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.Contains("Please enter your name", result);
        }
    }
}