using Blog.Application;
using Enter.ENB.Modularity;

namespace Blog.Infrastructure.DataAccess;

[DependsOnModules(typeof(ApplicationModule))]
public class InfrastructureDataAccessModule : EntModule
{
}