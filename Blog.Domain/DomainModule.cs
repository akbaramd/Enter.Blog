using Blog.Domain.Shared;
using Enter.ENB.Modularity;

namespace Blog.Domain;

[DependsOnModules(typeof(DomainSharedModule))]
public class DomainModule : EntModule
{
}