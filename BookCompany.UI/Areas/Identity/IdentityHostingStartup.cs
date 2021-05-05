using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(BookCompany.UI.Areas.Identity.IdentityHostingStartup))]
namespace BookCompany.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}