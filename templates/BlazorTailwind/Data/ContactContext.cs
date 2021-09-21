using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorTailwind.Data
{
    public class ContactContext : DbContext
    {
        public static readonly string RowVersion = nameof(RowVersion);

        public static readonly string ContactsDb = nameof(ContactsDb).ToLower();

        // public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        // {
        //     Debug.WriteLine($"{ContextId} context created.");
        // }
        
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property<byte[]>(RowVersion)
                .IsRowVersion();
            
            base.OnModelCreating(modelBuilder);
        }

        // public override void Dispose()
        // {
        //     Debug.WriteLine($"ContextId context disposed.");
        //     base.Dispose();
        // }
        //
        // public override ValueTask DisposeAsync()
        // {
        //     Debug.WriteLine($"{ContextId} context disposed async.");
        //     return base.DisposeAsync();
        // }
    }
}