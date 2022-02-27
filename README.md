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
