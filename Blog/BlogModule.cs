using Blog.Infrastructure.DataAccess;
using Enter.ENB.Modularity;

namespace Blog;
[DependsOnModules(typeof(InfrastructureDataAccessModule))]
public class BlogModule : EntModule
{
    public override Task ConfigureServicesAsync(ServiceConfigurationContext context)
    {
        return base.ConfigureServicesAsync(context);
    }

    public override Task OnApplicationInitializationAsync(ApplicationInitializationContext context)
    {
        return base.OnApplicationInitializationAsync(context);
    }
}