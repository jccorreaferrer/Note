using Note.Application.DTOs;
using Note.Application.Interfaces.Repositories;
using Note.Application.Interfaces.Services;
using Note.Application.Mapping;

namespace Note.Application.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _repository;
        public NoteService(INoteRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<NoteReadDTO>> GetListAsync()
        {
            var entities = await _repository.GetListAsync();
            return entities.Select(NoteMapping.ToReadDTO).ToList();
        }

        public async Task<NoteReadDTO> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
            {
                return null;
            }
            return NoteMapping.ToReadDTO(entity);
        }

        public async Task<IEnumerable<NoteReadDTO>> GetByIdsAsync(NoteGetByIdsDTO dto)
        {
            var entities = await _repository.GetByIdsAsync(dto);
            return entities.Select(u => NoteMapping.ToReadDTO(u));
        }

        public async Task<NoteReadDTO> InsertAsync(NoteInsertDTO dto)
        {
            var entity = NoteMapping.ToEntity(dto);
            entity = await _repository.InsertAsync(entity);
            return NoteMapping.ToReadDTO(entity);
        }
    }
}
