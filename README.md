# patterns
A library demonstrating various software patterns for educational purposes

Thus far the library contains the following patterns

*** DECORATOR ***

The decorator pattern is a way of adding functionality to a class by decorating it with another class.
This is usefull is you have several classes which might need various bits of functionality added 
to them but you don't want to make a sub class for every single one and you don't want to make 
them all into one giant class with loads of properties. Simply make a base class and then a bunch of
decorators and sequentiall decorate your classes with which ever extra functionlaity you need. 
For example take a bike class. You might have a mountain bike and a road bike. Each of these might 
need any combination of brakes, shocks and any other add on functionality. So instead of making 
a sub class for each simply make the base bike classes and the decorate them with brake decorators
and shocks decorators as you need to. 

