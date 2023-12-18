using Blog.Domain;
using Enter.ENB.Modularity;

namespace Blog.Application;

[DependsOnModules(typeof(DomainModule))]
public class ApplicationModule : EntModule
{
}