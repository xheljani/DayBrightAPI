using DayBrightAPI.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Patients> Patients { get; set; }
    public DbSet<Nurses> Nurses { get; set; }
}
