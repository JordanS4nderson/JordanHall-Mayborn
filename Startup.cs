using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JordanHall_Mayborn.Startup))]
namespace JordanHall_Mayborn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
