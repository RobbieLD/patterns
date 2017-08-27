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


*** Template ***

The template pattern allows the you to create an algorithm (a series of operations) which must be carried
out in a particular order. However it lets you define if if a the logic for each step really cares about
the class that it's operating on. Thus you can have some steps which have shared logic across all 
implimentations and some which are unique to certain implimentations. 

For example imagine building a bike. There are several steps to this process, some of which vary greatly 
depending on what kind of bike you are building and some are exactly the same no matter what kind of bike
you are building. 

This pattern is best for when the steps are known at design time. If they change at run time the the stratergy 
pattern might be better. 


