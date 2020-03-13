# Ryan Manchanthasouk
## C# Chapter 15 Homework
## March 1st, 2020
1. What is the dierence between a property and afield?
  - a field is a variable that is declared directly in a class or struct.
  - property is member that provides flexible mechansim to r, w, or x value of private field.  can be used as if they are public data members, they are actually accessors
1. What is the dierence between a property and a method?
  - property is a value stored in the hash key, whereas method is a function stored in hash key
1. What is your understanding of encapsulation?
  - It refers to the bundling of data with the methods that operate on that data. Encapsulation is used to hide the values or state of a structured data object inside a class, preventing unauthorized parties' direct access to them.
1. Some languages are case insensitive, that is, an "'a'" and an "\A" are considered to be the same letter. C# is case sensitive. What implications does this have regarding the naming of variables, methods, and other identiers? Do you think that the dierence in case in the initial character of two dierent identiers is sucient to distinguish them>
  - It is implied that you should not give methods and variables the same name to avoid confusion, so the difference in case is not sufficient enough to distinguish between two identifiers.
1. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use s write only property.
  - You would use a read-only property in a constructor.
  - You would use a write-only property when you don't want to expose internal representation.
1. Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.
  - The reason for making the getters and setters private is to make the corresponding part of the object's abstract state private. That's largely independent of the decision to use getters and setters or not. They also provide a place for adding debug code or injecting test code (for unit testing).
1. What are restrictions on the use of properties?
  - A property cannot be passed via ref or out parameter to a method: Properties cannot be passed via out or ref, as properties, are actually methods. Both ref and out are not considered to be a part of method signature at the time of compilation. Due to this, it will give a compile-time error. There is no solution to this restriction except to remove ref or out from the program entirely.
  - You cannot overload a property: A property cannot be overloaded. It means that one can only put a single get and set accessor and mutator in a class respectively. The program given below shows what happens when we give more than one get accessor in the same class.
1. What is an object initializer? What is the syntax for an object initializer?
  - Object initializers is the easiest and fastest way to assign values of an object's properties and fields. An object can be initialized without explicitly calling a class's constructor.
  - Object vname = new Object();
