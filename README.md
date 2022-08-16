# PremiumCalculator-REST-RF
Update of the application Premium Calculator to consider practices: SOLID Principles, DDD. I will be adding aditional practices to serve as an application example, and adding documentation to better understanding of the code.


SOLID design principles were first introduced by Computer Scientist Robert C. Martin in the year 2000.

***Domain-Driven Design***
DDD is an approach to business-focused software development. "As systems grow too complex to know completely at the level of
individual objects, we need techniques for manipulating and comprehending large models."

***Layers in DDD***
The architecture of DDD projects usually includes three main parts: Domain, Infrastructure, Application. Depending on the size of each project, we can arrange these parts in a project or separate them into different layers.

***Domain***: 
A place to define logic concepts, principles, patterns, and behaviors of data, including domain validation, calculations, and expressions for system operations.

<ul>
<li>Entities: POCO classes, construction, and model validation.
</li>
<li>Aggregate: The rules, computation, logic of domains, and related objects when updating the domain. According to Martin Fowler, an aggregate is a cluster of domain objects that can be treated as a single unit.
</li>
<li>Value objects: The value of an object related to Domain entities. In principle, ValueObjects have no identity, and once been initialized, will not be modified. They can be understood as immutable classes.
</li>
<li>Interfaces: They help define business behaviors, etc. Other layers will be responsible for implementing these definitions.
</li>
<li>Repository Interfaces/ServiceBase: The Interfaces of generic repositories, domain repositories, and services. Other layers will inherit and develop them.
</li>
<li>ILogger/DTOs/Exceptions: Notifications and information are transferred to other services.
</li>
<li>Others
</li>
</ul>

***Application***
<ul>
<li>Mobile application
</li>
<li>Web MVC/API application
</li>
<li>Desktop application
</li>
<li>IoT
</li>
<li>Others services
</li>
</ul>

***Infrastructure***

<ul>
<li>Repositories: Repositories will be implemented here, including GenericRepository and <Entity> Repository. 
</li>
<li>Data access: Contexts and the API connections link to databases. 
</li>
<li>SQL: ADO.NET, EntityFramework, Dapper, and ORM, etc.
</li>
<li>In-Memory stores.
</li>
<li>Caching, NoSQL, and so on.
</li>
<li>Data seeding
</li>
<li>Others:
Logging.
Cryptography.
Etc.
</li>
</ul>


***Dependency Injection***
Dependency injection is a programming technique that makes a class independent of its dependencies. It achieves that by decoupling the usage of an object from its creation.
<br>
This helps you to follow SOLID’s dependency inversion and single responsibility principles.
<br>
C# implements mechanism to implement Depedency injection. 



<br>
***Some important concepts***
<br>
<b>Interfaces vs Abstract clases</b>
<ul>
<li>
Intefaces: There are only signature of the methods, wich implies that a method does not have a body. 
</li>
<li>
Abstract clases: Abstract classes look a lot like interfaces, but they have something more: You can define a behavior for them.
</li>
</ul>


***References***
<ul>
<li>Domain-Driven Design Tackling Complexity in the Heart of Software by By Eric Evans  - Addison Wesley  
</li>
<li>
Architectural principles 
https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles#dependency-inversion
</li>
<li>Dependency injection in ASP.NET Core https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0
</li>
<li>Domain-Driven Design in ASP.NET Core applications https://enlabsoftware.com/development/domain-driven-design-in-asp-net-core-applications.html?amp=1
</li>
<li>
How to apply SOLID principles with practical examples in C#
https://enlabsoftware.com/development/how-to-apply-solid-principles-with-practical-examples-in-c-sharp.html?amp=1
</li>
<li>
Dependency injection in .NET 
https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection
</li>
<li>
Design Patterns Explained – Dependency Injection with Code Examples https://stackify.com/dependency-injection/
</li>

<li>
Unit of Work pattern
https://dotnettutorials.net/lesson/unit-of-work-csharp-mvc/#:~:text=The%20Unit%20of%20Work%20pattern,or%20fail%20as%20one%20unit.
</li>
</ul>
