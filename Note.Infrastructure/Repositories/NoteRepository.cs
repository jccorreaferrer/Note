using Note.Application.DTOs;
using Note.Application.Interfaces.Repositories;
using Note.Domain.Entities;
using Note.Infrastructure.Data;
using System.Threading.Tasks;

namespace Note.Infrastructure.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly NoteDbContext _context;

        public NoteRepository(NoteDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Note?> GetByIdAsync(int Id)
        {
            return await _context.Notes.FindAsync(Id);
        }

        public async Task<List<Domain.Entities.Note>> GetByIdsAsync(NoteGetByIdsDTO noteIds)
        {
            return await _context.Notes.Where(u => noteIds.Ids.Contains(u.NoteId)).ToListAsync();
        }

        public async Task<List<Domain.Entities.Note>> GetListAsync()
        {
            return await _context.Notes.ToListAsync();
        }

        public async Task<Domain.Entities.Note> InsertAsync(Domain.Entities.Note item)
        {
            await _context.Notes.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }
    }
}
