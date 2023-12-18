using System.Linq.Expressions;
using Blog.Domain.Users;
using Enter.Enb.Linq;

namespace Blog.Infrastructure.DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    public bool? IsChangeTrackingEnabled { get; }
    public Task<List<User>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<long> GetCountAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<List<User>> GetPagedListAsync(int skipCount, int maxResultCount, string sorting, bool includeDetails = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<User>> WithDetailsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<User>> WithDetailsAsync(params Expression<Func<User, object>>[] propertySelectors)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<User>> GetQueryableAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<User>> GetListAsync(Expression<Func<User, bool>> predicate, bool includeDetails = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public IAsyncQueryableExecuter AsyncExecuter { get; }
    public Task<User> InsertAsync(User entity, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task InsertManyAsync(IEnumerable<User> entities, bool autoSave = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<User> UpdateAsync(User entity, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task UpdateManyAsync(IEnumerable<User> entities, bool autoSave = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(User entity, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task DeleteManyAsync(IEnumerable<User> entities, bool autoSave = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<User?> FindAsync(Expression<Func<User, bool>> predicate, bool includeDetails = true,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<User> GetAsync(Expression<Func<User, bool>> predicate, bool includeDetails = true,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Expression<Func<User, bool>> predicate, bool autoSave = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task DeleteDirectAsync(Expression<Func<User, bool>> predicate, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}