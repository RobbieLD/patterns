# patterns
A library demonstrating various software patterns for educational purposes

Thus far the library contains the following patterns

*** Decorator ***

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


*** Singleton ***

  This is simply a class which can only ever be instantiated once. This is useful when you need to keep
  track of something across the entire application which can be changed by different users or at different 
  point. It is useful to note that according to Microsoft Statics are not singletons and thus not threadsafe. 


*** Observer ***

This pattern is used to allow an object to maintain a list of observers which it notifies of a change. 

For example imagine a bike manufacturing company who maintain a list of bike shops they notify about 
new models of their bikes. 

One issues with this can be that for long lived objects, if an observer gets set to null, the garbarge 
collection for this object won't happen because a reference to it in the list of observers is still held. 
This can be over come by using weak references and removing the observer from the list of observers
when it's no longer in use. See the code for how this is done. 


*** PublisherSubscriber ***

This pattern is very similar to the observer pattern but in this case the publisher doesn't know 
about subscribers unlike in the observer pattern when the observers are known and managed by the publisher.

For example imagine a bike shop which puts out notifications about new bikes they sell. Rather than maintining
a list of everyone who might be interested in a bike they simply make a broadcast and let anyone who's 
interested listen to and act on that broadcasts. 


*** Factory ***

A factory is a method is a means of abstracting the creation of an object away from it's use. Instead of newing 
and object and then using it straight away, using a factory to create your objects for you means that as long 
as they subscribe to a common interface you can get what ever kindof object you need from the factory. 

For example imagine several different type of bikes. As long they are all subscribe to the IBike interface you
can have a factory create you any one you like and you'll still be able to ride (use) it.

