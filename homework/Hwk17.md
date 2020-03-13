# Ryan Manchanthasouk
## C# Chapter 17 Homework
## March 9th, 2020
1. What is a type parameter?
  - a type parameter specifies the types that a generic class or method can use to operate
1. What does a type parameter do?
  - The type parameter is a placeholder for a specific type that a client specifies when an instance of a generic type is created.  
1. How many type parameters can a generic class have?
  - one or more type parameters separated by commas
1. What is the difference between a generic class and a generalized class?
  - General can take objects of any types, whereas generic refers to something which has no unique features.
1. What is a constraint? How do you specify a constraint?
  - Constraints inform the compiler about the capabilities a type argument must have.
  - where T : type
1. What is a generic method? How do you define a generic method?
  - With a generic method, you can specify the types of the parameters and the return type by using a type parameter like that used when you define a generic class.
  - You define generic methods by using the same type parameter syntax you use when you create
generic classes.
1. What do we mean when we say that a generic type interface is invariant?
  - An invariant generic type means that you can only use the type originally specified.
1. What do we mean when we say that a generic type interface is covariant?
  - It means that the generic type interface is enabled for implicit conversion of a more derived type to a less derived type.  
1. Does covariance work with value types? Does it work with reference types?
  - No, because they only apply to reference types.  If you specify a value type for a variant type parameter, that type parameter is invariant for the resulting constructed type.
1. What do we mean when we cay that a generic type interface is contravariant?
  - An interface that has a contravariant type parameter allows its methods to accept arguments of less derived types than those specified by the interface type parameter.
