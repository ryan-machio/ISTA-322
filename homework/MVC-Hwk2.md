# Ryan Manchanthasouk
## MVC Chapter 2 Homework
## February 26th, 2020
1. Describe what a controller does in the MVC design pattern.
  - Controllers handle incoming requests
    -Each public method in a controller is known as an action method, meaning you can invoke it from the Web via some URL to perform an action.
1. What is the ASP.NET MVC convention in naming controllers? What does HomeController.cs do?
  - The convention is to put controllers in the Controllers folder and the name convention is that controllers are followed by the word controller.
  - The HomeController.cs is a default controller class in your project.
1. What is the name of the routing configuration file? Where is it located?
  - cs file in App_Start Folder, the default route is Home Controller - Index Method.routes.
1. What is Razor? How does Razor treat an expression beginning with the at symbol (@)?
  - Razor is a view engine that processes the contents of views and generates HTML that is sent to the browser.  The expression symbol @ tells Razor to not use a layout.
1. How do View methods work?
  - Views have the name of the action method and are contained in a folder named after the controller.  View allow you to return other results from action methods besides strings and ViewResult objects.  
1. What is the purpose of MVC models?
  - The purpose of an MVC model is to represent real-world objects, processes, and rules that define the domain of the application.
1. What is a strongly typed view and why do we use strongly typed views?
  - To render specific model type, if the type is specified the user wants to work with (the GuestResponse class in the PartyInvites.Models namespace in this case), MVC can create some helpful shortcuts to make it easier.  
1. What is the purpose of setting a start page URL?
  - A start page URL will help the application figure out what the URL should be.
1. Describe the differences between HTTP GET and HTTP POST.
  - GET requests are what browser issues each time someone gets a link, which is responsible for displaying initial blank forms.
  - POST is responsible for receiving submitted data deciding what to do with it.
1. Describe the two approaches to validation in web applications.
  - Applying validation to the domain model rather than the user interface, which essentially allows the validation to take place anywhere in the application that the model class is used.
  - ASP-Validation summary attribute, which is applied to a div element, and displays a list of validation errors when the view is rendered.
1. What is the role of Cascading Style Sheets (CSS) in web development?
  - CSS is concerned with elements of presentation such as layout, font and colour and define the basis for a web application.
