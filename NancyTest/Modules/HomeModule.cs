using Nancy;
using NancyTest.Objects;

namespace NancyTest.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameters =>
            {
                var blogPost = new BlogPost
                {
                    Id = 1,
                    Title = "De ASP.NET MVC vers Nancy - Etape 2",
                    Content = "Lorem ipsum...",
                    Tags = { "c#", "aspnetmvc", "nancy" }
                };

                return View["Index", blogPost];
            };
        }
    }
}