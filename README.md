# LeagueDatabaseRazorPages
A League of Legends inspired player database using Razor Pages in ASP.net Core

Time and Space Complexity:
There are a lot of pros of using Razor Pages compared to other ASP.Net web forms. One of them is the time you will save. Scaffolding Razor Pages automatically adds a create, edit, details, and delete HTML and cshtml files which saves a lot of time instead of having to create those for each model. This makes it easy for people who are just getting into a database or for smaller databases. Razor Pages is also played out in a simpler and easier way to read. While I have not used any other types of web applications like MVN, from the research that I did, it seems that the organization is the biggest difference between Razor Pages and other ASP.Net web applications. Having such tightly organized models allows for the scalability of the application to be way easier. With each model having created separation of concern. Each model is very flexible and can communicate with other models easily, but each model still only contains what each model needs. For example, in my razor pages, I have 'Player' model and a 'Tournament' model. The PlayerID and the TournamnentID are tied together, this is what allows them to communicate without an instance of one being inside the other.


Sources:
https://stackify.com/asp-net-razor-pages-vs-mvc/
https://stackoverflow.com/questions/46777404/why-is-razor-pages-the-recommended-approach-to-create-a-web-ui-in-asp-net-core-2
https://www.thereformedprogrammer.net/six-things-i-learnt-about-using-asp-net-cores-razor-pages/