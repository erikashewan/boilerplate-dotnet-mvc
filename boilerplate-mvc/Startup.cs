using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(boilerplate_mvc.Startup))]
namespace boilerplate_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
