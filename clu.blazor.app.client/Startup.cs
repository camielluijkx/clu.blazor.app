using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace clu.blazor.app.client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            // Adds first Razor component to application (from there other components are started). 
            app.AddComponent<App>("app");
        }
    }
}
