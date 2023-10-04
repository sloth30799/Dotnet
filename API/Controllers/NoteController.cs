using BAL.IServices;
using Microsoft.AspNetCore.Mvc;
using MODEL.DTOs.TaskDTOs;
using MODEL.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController: ControllerBase
    {
        private readonly INoteService _noteService;
        public NoteController(INoteService noteService) 
        {
            _noteService = noteService;
        }

        [HttpGet("GetAllNotes")]
        public async Task<ActionResult<IEnumerable<Note>>> GetAllNotes()
        {
            var data = await _noteService.GetAllNotes();

            return Ok(data);
        }

        [HttpPost("CreateNote")]
        public async Task<ActionResult> CreateNote(CreateNoteDTO request)
        {
            await _noteService.CreateNote(request);

            return Ok(new {msg = "Create Success!"});
        }

        [HttpPut("UpdateNote")]
        public async Task<ActionResult> UpdateNote(Note request)
        {
            await _noteService.UpdateNote(request);

            return Ok(new { msg = "Update Success!" });
        }

        [HttpDelete("DeleteNote")]
        public async Task<ActionResult> DeleteNote(Note request)
        {
            await _noteService.DeleteNote(request);

            return Ok(new { msg = "Delete Success!" });
        }
    }
}
