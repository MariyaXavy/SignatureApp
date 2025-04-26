using Microsoft.EntityFrameworkCore;
using SignatureApp.Models;

namespace SignatureApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<UserForm> UserForms { get; set; }
    }
}
