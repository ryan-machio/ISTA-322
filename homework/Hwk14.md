# Ryan Manchanthasouk
## C# Chapter 14 Homework
## February 23th, 2020
1. What is the difference between a managed resource and an unmanaged resource?
  - Managed resources are anything managed by the CLR.
  - Unmanaged resources are native resources that are created and lifetime managed outside the CLR (except GDI handles or sockets).
1. When is memory for an object (reference type) allocated? When is the memory deallocated?
  - Memory for an object type is allocated to the data members of a class when an object of the class is declared.
  - The memory is deallocated when the object goes out of scope and the object is no longer being actively referenced to.
1. What is a destructor?
  - A destructor performs any tidying up that's required when an object is garbage collected.  The CLR will clear up any managed resources an object uses.
1. What is the difference in syntax between a constructor and a destructor?
  - A destructor has a tilde followed by the name of the class.
1. Give some examples of scarce resources. Why would you want to manage scarce resources?
  - Memory, database connections, and file handles.
  - These resources are too valuable because they take up memory on the disk.
1. What is exception-safe disposal?
  - Exception-safe disposal is when you call the disposal method in the finally block.
1. How do you think that the using statement works for resource management? Give an informal, English
language, explanation of how it works.
  - The using resource provides a clean mechanism for controlling the lifetime of resources.  The object is created with the using statement, and is destroyed once the block is finished.
1. What ill effects could result from attempting to dispose of a resource more than once?
  - If an object's Dispose method is called more than once, the object must ignore all calls after the first one. The object must not throw an exception if its Dispose method is called multiple times. Instance methods other than Dispose can throw an ObjectDisposedException when resources are already disposed.
1. We will look at threads later in the term. For now, what is your understanding of how threads interacts with resource management? A good guess is a sufficient answer to this question.
  - Threads are independent execution paths, which means that they are able to run simultaneously with other threads.  The CLR is able to automatically create threads, which it also disposes of.
1. Why does the book recommend not attempting to force the garbage collector? Are their any exceptions to this recommendation?
  - The book says this is not recommended because the process runs asynchonously, which means the method does no wait for garbage collection to be complete before it returns, so you still don't know whether your objects have been destroyed.
