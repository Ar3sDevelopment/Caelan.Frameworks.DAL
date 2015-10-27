#Caelan.Frameworks.DAL NuGet Package#

[![Join the chat at https://gitter.im/Ar3sDevelopment/Caelan.Frameworks.DAL](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/Ar3sDevelopment/Caelan.Frameworks.DAL?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

##What is it?
My DAL frameworks provide an empty IEntity interface and a generic IEntity with an ID of type T that must declare a get method. The T (or TKey) must implement the IEquatable interface, so you can use any object you want but remember the dependency.

##Why use it?
I need frequently a common type for my entities for generic repositories and abstract methods for CRUD operations and I thought you need too.

##Who needs it?
Anyone that wants to create abstract code and generics, working on DAL is not only DbContext and EF.
