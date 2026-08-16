using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Note.Application.DTOs
{
    public class NoteInsertDTO
    {
        public string NoteText { get; set; }
        [JsonIgnore]
        public int CreationAppUserId { get; set; }
    }
}
