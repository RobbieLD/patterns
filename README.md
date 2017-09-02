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


*** Publisher Subscriber ***

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

*** Abstract Factory ***

The abstract factory is much like the basic factory but instead of having a single factory which takes care 
of all theobject creation we instead have a factory for each group of objects we want to create. 

For example instead of having one single bike factory that has some logic inside it to work out which 
bike it should make, we instead have one base abstract factory. Then we have individual bike factories
for each type of bike which are called from the shops we want to sell those bikes at. Thus we can simply
create a bike shop of what ever type of bike we want and have it create (using the apropriate factory) the
bikes it needs. 


*** Stratergy ***


This pattern allows the changing of an algorithm's behavior at run time. Bascialy you have a class that 
performs some kind of algorithm but it can have the logic that changed because it's been abstracted out 
into an interface. 

For example imagine a set on instructions to build a bike and a class that does the building. You could 
change the way the bike is built by passing in a different set of instructions to the bike building class. 


*** Prototype ***

This provides a method for duplicating an object with while letting the object worry about the exact logic
how how it's done. The interface the object is coded to simply enforces the object must provide a clone method. 
This can then be use to duplicate an object with all the original property values in the new object. You 
can then modify any additional properties as you need.

For example imagine a bike production line. You want to be able to keep cloning bikes while only changing 
the serial number and leaving all the other properties the same. 



*** Builder ***

The builder provides a means of having a complex object constructed in a variety of predefined ways. It lets
a class create objects of a various type (interface or abstract class) with out worrying about the exact logic
of how they are created. 

For example imagine a bike factory where you have a bike builder that  can create a mountain bike. You also
have a builder that can make a road bike. Then you can simply pass instances of your various builders into 
your production class and it'll create as many of them as you need. 


*** Adapter ***

The adapter pattern allows you to create mapping code to convert one interface into another one. This is 
useful to avoid gluing your code to a particular implimentation of a third party provider of services. 

Imagine you have to supplies or bikes to you bike shop. A mountain bike supplier and a road bike supplier. 
You want to be able to call the same methods on each of them but their suppliers sell the bikes with 
different methods built in. You can simply create an adapter to convert one to the other. This is as simple
as creating an adapter class which impliments the interface which will be common between the bike types
and then adding an instance of which ever bike you're adapting to the adapter class. You can then
provide your own code to convert the types and methods from the custom bike provider versions
into your own common interface. 


*** Facade ***


The Facade pattern is very similar to to adapter pattern but instead of creating one interface to make 
one object look and behave like another one, the facade pattern creates an interface to select various 
methods and types from various other interfaces and cherry pick/rename/ammed the methods and types you
want on your new master interface. 

Imagine a bike shop which needs bike parts from three different suppliers of bike parts. They want the 
wheels from one, the breaks from another and the shocks from a third. A facade could be built so that 
a call to get the breaks simply works out which parts supplier it should go to, to get the brakes. 