using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(API.Startup))]
namespace API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           //Start up config goes here
        }
    }
}