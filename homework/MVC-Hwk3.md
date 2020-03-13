# Ryan Manchanthasouk
## MVC Chapter 3 Homework
## February 26th, 2020
1. The book states, \Interactions with an MVC application follow a natural cycle of user actions and view updates, where the view is assumed to be stateless." What does it mean for the view to be stateless?
  - Stateless means that HTTP doesn't have built in support for states; you can't store if a user has logged in or done something else.
1. The book identifies two kinds of models. Briefly describe each of them.
  - MVVM: model view, view model; facilitates a separation of development of the graphical user interface – be it via a markup language or GUI code – from development of the business logic or back-end logic (the data model).
  - MVC: MVC separates application into three components - Model, View and Controller. Model: Model represents shape of the data and business logic. It maintains the data of the application. Model objects retrieve and store model state in a database.
1. Give an example of separation of concerns from your own life experience. This should be a simple, everyday example.
  - Driving automatic vs. driving manual.
1. What is a view engine?
  - View Engine is responsible for rendering the view into html form to the browser
1. The book notes that the three-tier structure, or n-tier model, is \the most widely used pattern for business applications." Why do you think that this is true? An answer like, \Because it works well," is not a sufficient answer to this question.
  - The three tier model has no constraints on how the UI is implemented and provides good separation of concerns without being complicated.  
1. This question requires some outside research. When we study UWP, you will see that the UWP design pattern is the Model-View-View Model (MVVM). What is the difference between MVC and MVVM that makes the first good for ASP.NET MVC and the second good for UWP?
  - MVVM decouples UI code and non-UI code.  This means that you are able to change individual code without causing unintended side effects in other units, i.e. separation of concerns.  This allows the UWP xaml code to be completely separate from the cs code, meaning that if you decide to make changes in design or the latter, they will not effect each other.
  - MVC separates an application into three main components.  This separation allows programmers to manage complexity when you build an application, because it enables programmers to focus on one aspect of implementation at a time.  
1. Describe the two parts of the dependency injection (DI) design pattern.
  - Dependency: object that can be used, i.e. a service.
  - Injection: the passing of a dependency into the object that would use it.
1. Give an example of loose coupling from your own life experience. This should be a simple, everyday
example.
  - Weightlifting and cardiovascular training are both important to an athlete, however, they should be separate for powerlifters.  Cardiovascular training is specifically used for training endurance, while weight lifting is used to train strength.  However, together, they make a complete athlete.
1. What are the two types of testing discussed in the book?
  - Unit testing
  - Testing logic by separation of views and controller
1. What are the seven steps of the test driven development (TDD) work flow, as stated in the book?
  - Write test
  - Check if the test fails
  - If test passes, Rewrite test
  - Write production code
  - Run all tests
  - Clean up code
  - Rewrite Tests
