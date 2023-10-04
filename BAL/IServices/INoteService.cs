using MODEL.DTOs.TaskDTOs;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.IServices
{
    public interface INoteService
    {
        Task<IEnumerable<Note>> GetAllNotes();
        Task CreateNote(CreateNoteDTO note);
        Task UpdateNote(Note note);
        Task DeleteNote(Note note);
    }
}
