using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Note.Domain.Entities
{
    [Table("Note")]
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public string NoteText { get; set; }
        public bool IsActive { get; set; }
        public int? CreationAppUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? UpdateAppUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
