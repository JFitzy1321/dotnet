using Microsoft.EntityFrameworkCore;

namespace example
{
    public class DataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}