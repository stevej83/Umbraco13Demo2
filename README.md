# Umbraco13Demo2
Single page demo with Client/Server side validation and unit test

Technology Stack
Backend Framework: .NET 8
Content Management System (CMS): Umbraco 13
Database: SQLite
Frontend Framework: Bootstrap and jQuery

Umbraco Login Details
Username: jinyue306@gmail.com
Password: PW$12345678Go

Server-Side Form Validation
API Details
Endpoint: POST https://localhost:<your local port number>/umbraco/api/Form/Submit
Content-Type: application/json

Sample JSON Payload

{
  "Name": "Steve",
  "Email": "steve@gmail.com",
  "DOB": "1988-01-01"
}

Testing with Postman
Open Postman and set the request type to POST.
Enter the API endpoint URL: https://localhost:<your local port number>/umbraco/api/Form/Submit.
Go to the Body tab, select raw and set the format to JSON.
Paste the sample JSON payload into the body section.
Click Send to test the API.

Form Data Persistence
If the form validation is successful, the submitted data will be stored in a file named FormSubmissions.txt, located in the project's root directory. Each submission will be appended to the file in a readable format.

Example Format in FormSubmissions.txt
20241118 143906,Steve,steve@gmail.com,10880101
20241118 143921,Admin,jinyue306@gmail.com,20241105
20241118 144421,Admin,jinyue306@gmail.com,20241112
20241118 144516,Admin2,jinyue306@gmail.com,20241112
20241118 145122,AdminPAss,jinyue306@gmail.com,20241112

Frontend Design
The project leverages Bootstrap for responsive design and layout.
jQuery is used for form client side validations, and AJAX calls.

