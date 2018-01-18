using AdmHelper.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AdmHelper.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }        
    }
}