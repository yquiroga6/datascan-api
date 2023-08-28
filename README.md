# DataScan-Test-api

.NET 6.0 - Test API DataScan

# How to retrieve a list of all clients whit Postman
To get a list of all clients from the API follow these steps:

Open a new request tab by clicking the plus (+) button at the end of the tabs.
Change the HTTP method to GET with the dropdown selector on the left of the URL input field.
In the URL field enter the address to the clients route of your local API - http://localhost:4000/clientes
Select the Body tab below the URL field, change the body type radio button to raw, and change the format dropdown selector to JSON.
Click the Send button, you should receive a "200 OK" response with the message "Person created" in the response body.