using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MuhammedKarakayaNet.Startup))]
namespace MuhammedKarakayaNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
