Design Pattern Summary

* Creational Design Pattern:

  * Factory Method:

    Factory Method: is a creational design pattern that providea an interface for creating objects in a superclass, 
    but allow subclasses to alter the type  of objects that will be created.

    Pros:
    1. You avoid tight coupling between the creator and the concrete products.
    2. Single Responsibility Principle. You can move the product creation code into one place in the program, making the code easier to support.
    3. Open/Closed Principle. You can introduce new types of products into the program without breaking existing client code.

    Cons:
    1. The code may become more complicated since you need to introduce a lot of new subclasses to implement the pattern. 
    The best case scenario is when you’re introducing the pattern into an existing hierarchy of creator classes.

    Applicability:
    1. Use the Factory Method when you don’t know beforehand the exact types and dependencies of the objects your code should work with.
    2. Use the Factory Method when you want to provide users of your library or framework with a way to extend its internal components.
    3. Use the Factory Method when you want to save system resources by reusing existing objects instead of rebuilding them each time.
