using System;
using System.Collections.Generic;
using System.Text;

namespace Note.Application.DTOs
{
    public class NoteGetByIdsDTO
    {
        public List<int> Ids { get; set; } = [];
    }
}
