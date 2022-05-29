using Microsoft.EntityFrameworkCore;

namespace _4SemEksamen.Models
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options):base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
