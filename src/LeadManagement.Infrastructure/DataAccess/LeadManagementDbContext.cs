using LeadManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeadManagement.Infrastructure.DataAccess;

public class LeadManagementDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<LeadEntity> Leads { get; set; }

}
