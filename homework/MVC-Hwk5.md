# Ryan Manchanthasouk
## MVC Chapter 5 Homework
## March 11th, 2020
1. What is a view engine?
  - A view engine produces content to clients.
1. What is Razor?
  - Razor is the default view engine for ASP.NET Core MVC, which processes annotated HTML files for instructions that insert dynamic content into the output sent to the browser.
1. What do views do? List two specific things in your answer to this question.
  - Views display data from the model to the user
  - Views allow the user to modify the data that is displayed to the user
1. How does Razor respond when it encounters statements that begin with the at character (@)? Be specific.
  - @ allows one to use razor inside HTML, which in run time or precompiled, will be converted to c#.
1. How does Razor respond when it encounters statements that begin with the at character followed by
the colon (@:)? Be specific.
  - @ allows you to write c# within html
1. Describe how you implement a standard formatting for all pages in an ASP.NET application.
  - You would use layout pages, which will contain the content that every page will have.
1. What is the difference in using Razor to interpolate data values as stand-alone HTML elements and as attributes to HTML elements? What is the similarity?
  - Implicit, stand-alone HTML elements cannot contain spaces, while explicit, or attributes, can.
1. What is a view start file and where is it located?
  - The view start file contains code that is executed at the start of each RAzor Page's execution . It is located in the root of the views folder.
1. What is a Razor code block? What is the syntax of a Razor code block?
  - The razor code block is used to enclose C# Code statements.  These code blocks start with @ and are enclosed with {}.
1. Describe the difference roles of action methods and views.
  -
1. Describe the use of the @using statement. Give an example of how you would use it.
  - @using allows a programmer to access a namespace that isn't imported.
