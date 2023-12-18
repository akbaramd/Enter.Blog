using Enter.ENB.Domain.Values;

namespace Blog.Domain.Shared.Users;

public class UserId : EntValueObject
{
    public Guid Id { get; set; }
    
    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Id;
    }
}