using Note.Application.DTOs;
using Note.Domain.Entities;

namespace Note.Application.Interfaces.Repositories
{
    public interface INoteRepository
    {
        Task<List<Note.Domain.Entities.Note>> GetListAsync();
        Task<Note.Domain.Entities.Note?> GetByIdAsync(int Id);
        Task<Note.Domain.Entities.Note> InsertAsync(Note.Domain.Entities.Note item);
        Task<List<Note.Domain.Entities.Note>> GetByIdsAsync(NoteGetByIdsDTO noteIds);
    }
}
