$(document).ready(function () {
    $('#btnSubmit').click(function (event) {

        event.preventDefault();

        var name = $('#name').val();
        var email = $('#email').val();
        var dob = $('#dob').val();
        var error = $('#errorMessage');

        // Clear previous error message
        error.html('');

        // Regex for email validation
        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        if (name === '') {
            error.html('Please enter your name');
            return;
        }
        if (email === '') {
            error.html('Please enter your email');
            return;
        }
        if (!emailRegex.test(email)) {
            error.html('Please enter a valid email address');
            return;
        }
        if (dob === '') {
            error.html('Please enter your date of birth');
            return;
        }

        var dobDate = new Date(dob);
        var today = new Date();
        today.setHours(0, 0, 0, 0); // Set time to midnight to avoid time discrepancies

        if (dobDate > today) {
            error.html('Date of birth cannot be in the future');
            return;
        }

        // Submit the form if no errors
        $.ajax(
            {
                url: "/umbraco/api/Form/Submit",
                method: "POST",
                contentType: "application/json",
                dataType: "json",
                data: JSON.stringify({
                    Name: name,
                    Email: email,
                    DOB: dob
                }),
                success: function (data, textStatus, jqXHR) {
                    if (data.errorMessage.length == 0) {
                        error.html('Success');
                    }
                    else {
                        error.html('Error!');
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    error.html('Error with connection');
                }
            });
    });
});