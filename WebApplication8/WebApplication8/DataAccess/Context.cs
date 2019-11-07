namespace WebApplication8.DataAccess
{
    using System.Data.Entity;
    using WebApplication8.Models;

    public class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public DbSet<Post> Posts { get; set; } 
    }
}
