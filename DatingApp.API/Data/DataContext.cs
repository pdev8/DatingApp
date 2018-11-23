using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    // A DbContext instance represents a session w/ the db and can be used to query and
    // save instances of entities
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        }

        public DbSet<Value> Values {get; set;}
         
        public DbSet<User> Users {get; set;}
    }
}