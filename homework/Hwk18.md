# Ryan Manchanthasouk
## C# Chapter 18 Homework
## March 9th, 2020
1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will be handled by the team. For example, a ticket submitted a week ago has a higher priority than a ticked just submitted. What kind of data structure would you use, and why?
  - Queue, because it is a first-in, first-out data structure.
1. You are building a tracking system for seasonal agricultural farm labor. The labor requirements vary
widely, depending on the season. Your requirement is that the newest hires are terminated first, and
that our more experienced hires are kept longer. What kind of data structure would you use, and why?
  - Stack, because it is a first-in, last-out method
1. You are building a transaction database. Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently. In other words, data is typically added in the order in which the transaction occurs. What kind of data structure would you use, and why?
  - LinkedList, it is optimized to support insertion and removal at either end, but can randomly access data. (because when you insert or delete an item from the LinkedList )
1. You are building an analytical database. Your requirement is that the database handle queries very
quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind
of data structure would you use, and why?
  - Dictionary, because it is a collection of definite values that cannot be modified.
1. You are building a personnel directory, where searched are performed by last name,first name, middle name. What kind of data structure would you use, and why?
  - SortedList, because it is a list of key/value pairs.
1. You are building a username/password database. Your requirement is that updates happen frequently (when users change their passwords) and that searches (to authenticate users) happen extremely quickly. What kind of data structure would you use, and why?
  - HashSet, because it is optimized for fast retrieval of data and has set-oriented methods for determining whether the items it holds are a subset of those in another HashSet
1. What is a lambda expression? Give an example. Why would we use a lambda expression?
  - An expression that returns a method.  x => x*x
  - var squaredNumbers = numbers.Select(x => x * x);
1. What is the difference between lambda expressions and anonymous methods? What are the advantages
of each?
  - Lambda methods provide a more succinct and natural syntax than anonymous methods, and they pervade many of the more advanced aspects.
  - With anonymous methods, you do not have to name them yourself and they are only concerned about calling the method.
  - With the Lambda Expression, they are used in frameworks that want to know what the code does and how, so that the process can be optimized.

  - Anonymous methods are useful for avoiding name collisions
