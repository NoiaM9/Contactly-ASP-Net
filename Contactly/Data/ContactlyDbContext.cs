using Contactly.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Contactly.Data
{
    public class ContactlyDbContext : DbContext
    {
        //creez constructor pentru aceasta clasa
        public ContactlyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
