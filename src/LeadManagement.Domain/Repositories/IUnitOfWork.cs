namespace LeadManagement.Domain.Repositories;

public interface IUnitOfWork
{
    Task Commit();
}
