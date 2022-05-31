using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuDinhPhong_Bai3.Startup))]
namespace VuDinhPhong_Bai3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
