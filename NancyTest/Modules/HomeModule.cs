using Nancy;

namespace NancyTest.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameters =>
            {
                return View["Index"];
            };
        }
    }
}