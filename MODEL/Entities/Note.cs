using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Done { get; set; } = false;
    }
}
