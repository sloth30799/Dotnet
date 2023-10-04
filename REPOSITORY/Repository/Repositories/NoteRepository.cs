using MODEL.Entities;
using REPOSITORY.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY.Repository.Repositories
{
    internal class NoteRepository: GenericRepository<Note>, INoteRepository
    {
        public NoteRepository(DataContext context): base(context)
        {

        }
    }
}
