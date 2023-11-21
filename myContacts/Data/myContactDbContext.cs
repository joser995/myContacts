using Microsoft.EntityFrameworkCore;
using myContacts.Models;

namespace myContacts.Data
{
    public class myContactDbContext : DbContext
    {
        public myContactDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            IList<Contact> defaultContacts = new List<Contact>() {
                new() {
                            ContactId = 1,
                            Name = "Jose Ramos",
                            Phone = "7876745062",
                            Email = "jramosaviles.dev@gmail.com",
                            Notes = "This is a test contact",
                        },
                new()
                {
                            ContactId = 2,
                            Name = "Peter Parker",
                            Phone = "7875145265",
                            Email = "peterparker@example.com",
                            Notes = "This is another test contact",
                },
                new()
                {
                            ContactId = 3,
                            Name = "John Doe",
                            Phone = "1234567890",
                            Email = "johndoe@example.com",
                            Notes = "This is another test contact",
                },
                new()
                {
                            ContactId = 4,
                            Name = "Jane Smith",
                            Phone = "9876543210",
                            Email = "janesmith@example.com",
                            Notes = "Yet another test contact",
                },
                new()
                {
                            ContactId = 5,
                            Name = "Alice Johnson",
                            Phone = "5555555555",
                            Email = "alicejohnson@example.com",
                            Notes = "One more test contact",
                }
            };
            modelBuilder.Entity<Contact>().HasData(defaultContacts);
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
