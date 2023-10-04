using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.DTOs.TaskDTOs
{
    public class CreateNoteDTO
    {
        public string Name { get; set; } = null!;
        public bool Done { get; set; } = false;
    }
}
