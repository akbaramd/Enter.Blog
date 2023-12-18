using Blog.Domain.Shared.Users;
using Enter.ENB.Domain.Auditing;

namespace Blog.Domain.Users;

public class User : AuditedAggregateRoot<UserId>
{
    
}