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


*** Command ***


The command pattern allows a class to control a flow of steps which being able to progress backwards (option)
in the flow if it needs to. This is useful to decouple of actual logic behind each step with the managment 
of the steps.

Imagine a bike rider who can turn left or right and go forwards or backwards. We can use a command pattern
to issue commands to him to ride in any direction and we can keep track of his steps so we can ask him
to undo any number of them. It is importatnt to note that we can't go back to an arbitary state in the 
history of the commands, we can only go back one command at a time (think linked list).


*** Memento ***


Like the command pattern the memonto pettern enables the saving of an object's state. Unlike the command pattern 
where we can only go back and forth along the history of the object, the memento patter simply creates a snapshop
of an object (a memento) which can be restored back at a later time. 

Imagine a bike race and everytime you go through a checkpoint you want to be able to return to that point 
if you need to. The memento pattern can easily acumplish this.


*** Bridge ***

The bridge pattern is a way of swapping out the actual implimentation of a class 
at run time while preverving it's functionality. This is done by having the 
implimentations details contained inside an instance variable of the main class 
which can be changed (through accessor functions) when ever needed while out affecting 
the way the main class is caleld or used. 

For example imagine a bike rider which want's to ride a bike. However we want to be 
able to change the bike rider class at run time so they rider can ride any kind
of bike as long as the bike impliments a common interface. 

*** Proxy ***


The proxy pattern is where an interface is implimented by a class, usually making
some kind of call to a third party application or service. To use this we then use
a proxy class which also impliments the same interface but contains an instance of
the original class (the actual implimentation). This allows for the details of 
creating the service and the authenticaion and such to be hidden in side the original 
class and the proxy to just handle callign the correct methods.

For example imagine a bike shop that needs to check sto levels in it's warehouses.
the warehouses expose services to check their stock levels. We can then make a class
which does the checking of stock levels and a proxy for this which impliments the same
interface but contains an instance to the original implimentation. 


*** Compisite ***


The compisite pattern is bascialyl a tree data structure. It allows the addition of 
leaf nodes which end the branch they are attached to and also compisite nodes which
them selves can contain child nodes. This pattern also allows a compisitie note 
to expose a means of traversing the tree.

For example imagine a tree structure representing various different types of bikes.
At the root of the tree is a basic bikes and the further down the tree you go
the more specialised the bike becomes and the more it diverges from the original bike. 
The leaf nodes (end nodes) are the production bikes which go on sale to the clients
where as the compisite nodes are the prototype bikes which lead to final version of
production bikes. 


*** Flyweight ***

The flyweight pattern is used to control a large number of objects all inheriteded 
from the same base type. A factory class is used to lazily create these as needed
and return them as needed. 

Imagine a bike race where there are hundreds of bikes but only a few different types
the bikes can be. Instead of making hundreds of classes or instantiating the several
classes hundreds of times, a flyweight implimentation will handle the creation of the
bike types and everytime a particular type is needed, it will return either the instance
it's already created or a new one if this type hasn't been used before. This was there
is every only the minimum required number of instantiated classes to represent all the 
bikes in the race. 

*** State ***

This pattern allows an object to maintain and internal state which can change based on 
property changes or method calls. This internal state has changes the internal 
functionality of the object making it look a bit like it's changed type. This is done
by having a state class instance variable in the main class which can be swapped for
another state calss if some condition is met that requires a state change.

For example imagine a Bike which changes from a Road bike to a mountain bike depending
on the addition or removal of various componants. If you have a bike is behaves like a 
road bike until you add shocks then it behaves like a mountain hybrid bike until you 
add disc brakes and then it changes to a mountain bike. If you remove these parts
it will change back to a road bike. 


*** Iterator ***

The istorator pattern allows a collection of objects to expose an iterator which 
iterates over them with out exposing their unerlying structure. 

For example imagine a bike production line which you can add bikes to. You do how
ever need a way of iterating over them in order to do any kind of meaningful work 
on them. 

Note: The implimentation of this in the code isn't the most straight forward. It's 
probably easier to do it with an unerlying array, however I've chosen to do it all
with a simply linked list of Bike types.

*** Mediator ***

This pattern provides a means for objects to communicate with each other by means of 
a mediator class. The mediators job is to manage communication between the objects
and make sure they are talking to eachother in the correct way. 

For example imagine a bike auction where there are four participants. Three of them
are bidding on the bikes and one of them is the auctioneer. The mediator class (the 
auction) has the job of making sure the auctioneer talks to everyone and the bidders
only talk to the auctioneer.