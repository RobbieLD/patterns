# Common Software Patterns
A library demonstrating various software patterns for educational purposes with examples in C# and TypeScript. These pattern examples are to try and give a single reference for most of the commonly used software patterns. It's important to note that these patterns can often vary in their implimentation particularly around the use of interfaces and abstract classes. These examples are simply one way to do these patterns and are meant more to convey the genreal idea behind the pattern than an exact solution for implimenting them. Software patterns them selves are not copy and pastable solutions to problems but principals which can be applied to a wide range of problems. It's to try and convey the principal rather than the exact solution that this library has been created. 

These patterns are intented to be read and used as guides however for working examples a runner in `Program.cs` is provided for each one. This means you can run the project and debug to see each pattern in use. There are also tests for each pattern showing the important aspects of each pattern and how to test for it. Note that these tests are not exhaustive and more given as examples of how to test the pattern.

## Behavioral Patterns

### Iterator

The istorator pattern allows a collection of objects to expose an iterator which iterates over them with out exposing their unerlying structure. 

For example imagine a bike production line which you can add bikes to. You do how ever need a way of iterating over them in order to do any kind of meaningful work on them. 

Note: The implimentation of this in the code isn't the most straight forward. It's probably easier to do it with an unerlying array, however I've chosen to do it all with a simply linked list of Bike types.

### Mediator

This pattern provides a means for objects to communicate with each other by means of a mediator class. The mediators job is to manage communication between the objects and make sure they are talking to eachother in the correct way. 

For example imagine a bike auction where there are four participants. Three of them are bidding on the bikes and one of them is the auctioneer. The mediator class (the auction) has the job of making sure the auctioneer talks to everyone and the bidders only talk to the auctioneer.

### Servant

This pattern is sort of like a helper class. When you have a chunk of functionality which should be avaliable to a bunch of differents classes but you don't want those classes to actually need to know about the implimentation of the functionality you can use the servant patter. 

For example imagine we've got several different types of bikes. They have different speeds and need to be able to ride from one location to another. They only really need to know their current location and not the details of how they got there so we use a serval class to handle the calculations of their new positions and time of arrival and keep the bike class clean with only the bits of information impornt to it.

### Interpreter

This pattern provides a means of interpreting a certain language or set of objects stored in a context into another set based on converter expressions defined in the interpreter.

For example imagine a bike interpreter that took imported bikes with imperial measurments on them and converted them to metric. 

### Visitor

The visitor pattern defines a way of allowing objects contained in a structure to be visited by a series of visitors which can perform operations on each of them. 

For example imagine a workshop full of bikes. We have two visitor robots which go to each bike. One paints it a new colour and the other pumps up the tires;

### Chain of Responsibility

This pattern allows a request to be decoupled from the object which handles it by making all the objects which could handled it form a chain. The request is then passed down the chain until it an object handles it or it reaches the end of the chain and is un handled.

For example imagine a chain of bike shops. A customer makes a request to purchase a bike and their request is passed down the chain of shops until one has the correct stock on hand to fill the order. 

### Specification

This pattern provides a means of hard coding business logic into small units (called specifications) which can be combined to make more complex specifications. This also provides a single point of truth for this logics avoiding it bleeding into the data access code and thus keeping the code DRY (Don't repeat your self).

For this example, imagine a bike warehouse with many different bikes which a bike shope might want to be able to search to fill a customer order. There are many different types of bikes with differents attributes which such as wheel size, number of gears and type of bike. If the shop wishes to all the childrens bikes we can combine a number of specifications (about number of gears and wheel size etc.) into one complex which the shop can them use to search the warehouse. This way the logic about what is considered a childresn bike can be stored in a single place in the shop code and the warehouse doesn't need to worry about it. Also the logic about the bikes can be broken down into small chunks which can be reused for other searches.

### State

This pattern allows an object to maintain an internal state which can change based on property changes or method calls. This internal state changes the internal functionality of the object making it look a bit like it's changed type. This is done by having a state class instance variable in the main class which can be swapped for another state calss if some condition is met that requires a state change.

For example imagine a Bike which changes from a Road bike to a mountain bike depending on the addition or removal of various componants. If you have a bike it behaves like a road bike until you add shocks then it behaves like a hybrid bike until you add disc brakes and then it changes to a mountain bike. If you remove these parts it will change back to a road bike. 

### Memento

Like the command pattern the memonto pettern enables the saving of an object's state. Unlike the command pattern where we can only go back and forth along the history of the object, the memento patter simply creates a snapshop of an object (a memento) which can be restored back at a later time. 

Imagine a bike race and everytime you go through a checkpoint you want to be able to return to that point if you need to. The memento pattern can easily acumplish this.

### Command

The command pattern allows a class to control a flow of steps which being able to progress backwards (option) in the flow if it needs to. This is useful to decouple of actual logic behind each step with the managment of the steps.

Imagine a bike rider who can turn left or right and go forwards or backwards. We can use a command pattern to issue commands to him to ride in any direction and we can keep track of his steps so we can ask him to undo any number of them. It is importatnt to note that we can't go back to an arbitary state in the history of the commands, we can only go back one command at a time (think linked list).

### Template

The template pattern allows the you to create an algorithm (a series of operations) which must be carried out in a particular order. However it lets you define if if a the logic for each step really cares about the class that it's operating on. Thus you can have some steps which have shared logic across all implimentations and some which are unique to certain implimentations. 

For example imagine building a bike. There are several steps to this process, some of which vary greatly depending on what kind of bike you are building and some are exactly the same no matter what kind of bike you are building. 

This pattern is best for when the steps are known at design time. If they change at run time the the stratergy pattern might be better. 

### Stratergy

This pattern allows the changing of an algorithm's behavior at run time. Bascialy you have a class that performs some kind of algorithm but it can have the logic that changed because it's been abstracted out into an interface. 

For example imagine a set on instructions to build a bike and a class that does the building. You could change the way the bike is built by passing in a different set of instructions to the bike building class. 

### Observer

This pattern is used to allow an object to maintain a list of observers which it notifies of a change. 

For example imagine a bike manufacturing company who maintain a list of bike shops they notify about new models of their bikes. 

One issues with this can be that for long lived objects, if an observer gets set to null, the garbarge collection for this object won't happen because a reference to it in the list of observers is still held. This can be over come by using weak references and removing the observer from the list of observers when it's no longer in use. See the code for how this is done. 

### Publisher Subscriber

This pattern is very similar to the observer pattern but in this case the publisher doesn't know about subscribers unlike in the observer pattern when the observers are known and managed by the publisher.

For example imagine a bike shop which puts out notifications about new bikes they sell. Rather than maintining a list of everyone who might be interested in a bike they simply make a broadcast and let anyone who's interested listen to and act on that broadcasts. 

## Creational Patterns

### Builder

The builder provides a means of having a complex object constructed in a variety of predefined ways. It lets a class create objects of a various type (interface or abstract class) with out worrying about the exact logic of how they are created. 

For example imagine a bike factory where you have a bike builder that  can create a mountain bike. You also have a builder that can make a road bike. Then you can simply pass instances of your various builders into your production class and it'll create as many of them as you need. 

### Prototype

This provides a method for duplicating an object with while letting the object worry about the exact logic how how it's done. The interface the object is coded to simply enforces the object must provide a clone method. This can then be use to duplicate an object with all the original property values in the new object. You can then modify any additional properties as you need.

For example imagine a bike production line. You want to be able to keep cloning bikes while only changing the serial number and leaving all the other properties the same. 

### Abstract Factory

The abstract factory is much like the basic factory but instead of having a single factory which takes care of all theobject creation we instead have a factory for each group of objects we want to create. 

For example instead of having one single bike factory that has some logic inside it to work out which bike it should make, we instead have one base abstract factory. Then we have individual bike factories for each type of bike which are called from the shops we want to sell those bikes at. Thus we can simply create a bike shop of what ever type of bike we want and have it create (using the apropriate factory) the bikes it needs. 

### Singleton

This is simply a class which can only ever be instantiated once. This is useful when you need to keep track of something across the entire application which can be changed by different users or at different point. It is useful to note that according to Microsoft Statics are not singletons and thus not threadsafe. 

### Factory

A factory is a method is a means of abstracting the creation of an object away from it's use. Instead of newing and object and then using it straight away, using a factory to create your objects for you means that as long as they subscribe to a common interface you can get what ever kindof object you need from the factory. 

For example imagine several different type of bikes. As long they are all subscribe to the IBike interface you can have a factory create you any one you like and you'll still be able to ride (use) it.

## Structural Patterns

### Twin

The twin pattern is designed to allow a simulation of multiple inheritance when the language doesn't support it. In the case of c# a class can only ininherit from a single parent class. In order to get around this we use the twin patter. Here we have two parent classes which are inherited by two child classes. These child classes are the twin classes which then hold instance varaibles of each other so they can access the methods from the other parent classes.

For example image a hybrid bike which needs to inherit methods from both a mountain bike and a road bike. Here we will extend both road and mountain bikes and these new inherited bikes have instance variables which point to each other.

### Marker

The marker pattern is a means of indicating a particular class contains certain capabilities which can be checked at run time. 

For example consider a bike race. We have a lot of bikes entering but there are specific requirements around what bikes can enter the race. The details of what constitues a race worthy bikes is up to us but we need a way of indicating which bikes can enter the race so that the race marshals know who to allow in and who to keep out. We can achive this by making an empty interface which the bikes who are allowed into the race can inherit. It's important to note that the .Net guidelines discourage the use of an empty marker interface and encourage the use of attributes instead. In the code example for this pattern we will show both ways because there are certain advantages to using empty marker interfaces over attributes which is include ease of use and also support for generics.

### Flyweight

The flyweight pattern is used to control a large number of objects all inheriteded from the same base type. A factory class is used to lazily create these as needed and return them as needed. 

Imagine a bike painting workshop. It might paint hundreds of bikes but it's only going to paint then a selected predefind range of colours. We need a paint robot for each color but we don't want to create a new color robot for every bike that needs to be painted. so when we need a green robot we check our robot collection, if we've got a green one we use it and if not, only then do we make one. This same pattern follows for all colours we need to paint a robot. This way we might paint thousands of bikes but we won't be making new painting robots unless there's a new color we need to support.

### Compisite

The compisite pattern is bascialyl a tree data structure. It allows the addition of leaf nodes which end the branch they are attached to and also compisite nodes which them selves can contain child nodes. This pattern also allows a compisitie note to expose a means of traversing the tree.

For example imagine a tree structure representing various different types of bikes. At the root of the tree is a basic bikes and the further down the tree you go the more specialised the bike becomes and the more it diverges from the original bike. The leaf nodes (end nodes) are the production bikes which go on sale to the clients where as the compisite nodes are the prototype bikes which lead to final version of production bikes.

### Proxy 

The proxy pattern is where an interface is implimented by a class, usually making some kind of call to a third party application or service. To use this we then use a proxy class which also impliments the same interface but contains an instance of the original class (the actual implimentation). This allows for the details of creating the service and the authenticaion and such to be hidden in side the original class and the proxy to just handle callign the correct methods.

For example imagine a bike shop that needs to check sto levels in it's warehouses. The warehouses expose services to check their stock levels. We can then make a class which does the checking of stock levels and a proxy for this which impliments the same interface but contains an instance to the original implimentation. 

### Bridge

The bridge pattern is a way of swapping out the actual implimentation of a class at run time while preverving it's functionality. This is done by having the implimentations details contained inside an instance variable of the main class which can be changed (through accessor functions) when ever needed while out affecting the way the main class is caleld or used. 

For example imagine a bike rider which want's to ride a bike. However we want to be able to change the bike rider class at run time so they rider can ride any kind of bike as long as the bike impliments a common interface. 

### Facade

The Facade pattern is very similar to to adapter pattern but instead of creating one interface to make one object look and behave like another one, the facade pattern creates an interface to select various methods and types from various other interfaces and cherry pick/rename/ammed the methods and types you want on your new master interface. 

Imagine a bike shop which needs bike parts from three different suppliers of bike parts. They want the wheels from one, the breaks from another and the shocks from a third. A facade could be built so that a call to get the breaks simply works out which parts supplier it should go to, to get the brakes. 

### Adapter

The adapter pattern allows you to create mapping code to convert one interface into another one. This is useful to avoid gluing your code to a particular implimentation of a third party provider of services. 

Imagine you have to supplies or bikes to you bike shop. A mountain bike supplier and a road bike supplier. You want to be able to call the same methods on each of them but their suppliers sell the bikes with different methods built in. You can simply create an adapter to convert one to the other. This is as simple as creating an adapter class which impliments the interface which will be common between the bike types and then adding an instance of which ever bike you're adapting to the adapter class. You can then provide your own code to convert the types and methods from the custom bike provider versions into your own common interface. 

### Decorator

The decorator pattern is a way of adding functionality to a class by decorating it with another class. This is usefull is you have several classes which might need various bits of functionality added to them but you don't want to make a sub class for every single one and you don't want to make them all into one giant class with loads of properties. Simply make a base class and then a bunch of decorators and sequentiall decorate your classes with which ever extra functionlaity you need. For example take a bike class. You might have a mountain bike and a road bike. Each of these might need any combination of brakes, shocks and any other add on functionality. So instead of making a sub class for each simply make the base bike classes and the decorate them with brake decorators and shocks decorators as you need to. 

## Concurrency Patterns

### Lock

The lock pattern is a means to make sure that a particular recource can only be updated by a single thread thread at one time. 

Consider a bunch of bike shops all selling bikes from the same warehouse. If the requests to sell bikes from each of the shops arrive at the bike warehouse concurrently we need these to be enforce a lock so that only one request at a time can be handled or it's possible that when there is only one bike left two bike shops might try to sell it at the same time.