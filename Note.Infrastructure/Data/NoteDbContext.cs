using Microsoft.EntityFrameworkCore;
using Note.Domain.Entities;
using System.Net.Sockets;


namespace Note.Infrastructure.Data
{
    public class NoteDbContext : DbContext
    {
        public NoteDbContext(DbContextOptions<NoteDbContext> options) : base(options)
        {
        }
        public DbSet<Note.Domain.Entities.Note> Notes { get; set; }


    }
}
