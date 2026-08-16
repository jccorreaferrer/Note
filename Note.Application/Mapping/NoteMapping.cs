using Note.Application.DTOs;
using Note.Domain.Entities;

namespace Note.Application.Mapping
{
    public class NoteMapping
    {
        public static NoteReadDTO ToReadDTO(Note.Domain.Entities.Note entity)
        {
            return new NoteReadDTO
            {
                NoteId = entity.NoteId,
                NoteText = entity.NoteText,
            };
        }
        public static Note.Domain.Entities.Note ToEntity(NoteInsertDTO dto)
        {
            return new Note.Domain.Entities.Note
            {
                NoteText = dto.NoteText,
                CreationAppUserId = dto.CreationAppUserId,
                IsActive = true,
                CreationDate = DateTime.UtcNow,
            };
        }
    }
}
