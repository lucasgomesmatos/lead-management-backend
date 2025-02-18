using LeadManagement.Domain.Repositories;

namespace LeadManagement.Infrastructure.DataAccess;

internal class UnitOfWork(LeadManagementDbContext dbContext) : IUnitOfWork
{
    public async Task Commit() => await dbContext.SaveChangesAsync();
}
