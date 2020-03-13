# Ryan Manchanthasouk
## MVC Chapter 4 Homework
## February 26th, 2020
1. Using automatic properties is a shortcut that avoids several explicit steps. List the steps that the use of automatic properties avoids.
  - Automatic properties save developers from writing primitive getters and setters.
1. Using the object initializer syntax is a shortcut that avoids several explicit steps. List the steps that the use of object initializers avoids.
  - Object initializer syntax allows a programmer to initialize objects in a declarative manner without explicitly invoking a constructor for the type.
1. What is the purpose of creating extension methods?
1. What is the one feature of extension methods that will always allow you to identify a method as an extension method?
   - An extension method is one that is used to extend the functionality of existing types by adding methods sans the need of creating new derived types. You don't need to create subclasses of existing classes or recompile or modify your existing classes to work with extension methods.
1. How do you create an extension method that alters the results returned by the method on a user specified criterion?
  - Create an extension method class, where you declare your extension methods that you want to use in your main program.
1. Explain the syntax of a lambda expression. The term \lambda expression" originates in the lambda calculus developed by the mathematician Alonzo Church in the 1930's. There is a class of programming languages that are based on the fundamental ideas of lambda calculus.
  - the lambda expression requires a lambda declaration opreator => to separate the lambada's parameter list from its body.  You specify input parameters on the left and the expression or statement on the right.
1. This will require some outside research. What is the distinction between an anonymously typed variable and a dynamically typed variable?
  - An anon typed variable is a type that doesn't have any name.
  - A dynamically typed variable is a type that is created using the dynamic keyword.  The compiler does not check the type at compile time, but at run time instead.
1. You are having a discussion about C# with a friend of yours that uses another language. You are telling him about C#'s LINQ library. How would you describe to him the difference between LINQ's SQL-like notation and LINQ's dot notation?
  - LINQ's SQL-like notation starts with the from keyword and ends with the select keyword.
  - LINQ's dot notation is more concise, as you can easily select sections that you need.
1. What, exactly, does the await keyword do?
  - Await tells the C# compiler that the programmer wants to wait for the result of the task that the getasync method returns and then carry on executing other statements in the same method.
1. What is the connection between await and the async keywords?
  - Async makes a function asynchronous, which unlocks the use of await inside these functions.  
