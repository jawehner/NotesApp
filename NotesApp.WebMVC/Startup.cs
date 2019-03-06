using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NotesApp.WebMVC.Startup))]
namespace NotesApp.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
