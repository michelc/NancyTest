using Nancy;
using Nancy.ModelBinding;
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

            Get["/new"] = parameters =>
            {
                var blogPost = new BlogPost();

                return View["New", blogPost];
            };

            Post["/new"] = paramters =>
            {
                var blogPost = this.Bind<BlogPost>();

                // Redirige l'utilisateur vers l'action Index avec le titre du billet saisie dans l'URL
                return Response.AsRedirect("/?title=" + blogPost.Title);
            };


        }
    }
}