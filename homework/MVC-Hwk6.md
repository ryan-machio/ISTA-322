# Ryan Manchanthasouk
## MVC Chapter 6 Homework
## March 11th, 2020
1. What is the primary idea that underlies Dependency Injection?
  -  The intent behind dependency injection is to achieve Separation of Concerns of construction and use of objects.
1. Describe the role of interfaces in implementing a dependency injection container.
  - The role of interfaces in dependency injection is separating the what from the how.  In this sense, interfaces are the what, and the classes that derive from the interfaces are the how.
1. List the three stages of building basic ninject functionality, and briefly define each stage.
  - Ninject is a dependency injector for .NET, practical realization of pattern Dependency Injection (form of inversion of control pattern)
  - Inversion of Control (IoC): Container (a.k.a. DI Container) is a framework for implementing automatic dependency injection. It manages object creating and its lifetime and also injects dependencies to the class.
  - Dependency Injection: technique whereby one object supplies the dependencies of another object
  - Inversion of Control Containers and the Dependency Injection Pattern: DI is a form of IoC, where implementations are passed into an object through constructors/setters/service lookups.
1. What is the purpose of a custom dependency resolver?
  - So that the user can manipulate the methods that are defined.
1. What is the purpose of conditional binding? Describe how it works.
  - Gets or sets the binding that specifies the property of the condition.   
  - Performs different computations or actions dependong on whether a programmer-specified boolean condition that evaluates to true or false.
1. Why is setting the object scope important when using dependency injection?
  - You can move the constructor and wiring of objects to the injector's purview.  This allows the inejctor manage the latent state of your objects.  
1. Briefly describe the Test Driven Development approach in developing an application.
  - You must write a test that fails before you write a new functional code.
1. Consider the Assert class. How do you access the methods of that class?
  - A collection of helper classes to test various conditions within unit tests.
  -   public static Microsoft.VisualStudio.TestTools.UnitTesting.Assert That { get; }
  - Use the "that" keyword in the property that you are utilizing the Assert class.
1. Why is it useful to mock objects when developing software?
  - Mock objects allow developers to focus tests on the behavior of the system without worrying about dependencies.
1. Briefly describe the two main issues that arise when attempting to do Unit Tests without the aid of some sort of mocking library.
  - You could potentially break the code.
  - You cannot isolate smaller blocks of code, which is the primary purpose of unit testing.
