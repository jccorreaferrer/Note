using Note.Application.DTOs;

namespace Note.Application.Interfaces.Services
{
    public interface INoteService
    {
        Task<IEnumerable<NoteReadDTO>> GetListAsync();
        Task<NoteReadDTO> GetByIdAsync(int id);
        Task<NoteReadDTO> InsertAsync(NoteInsertDTO dto);
        Task<IEnumerable<NoteReadDTO>> GetByIdsAsync(NoteGetByIdsDTO dto);
    }
}
