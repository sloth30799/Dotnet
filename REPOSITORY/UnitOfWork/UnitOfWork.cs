using REPOSITORY.Repository.IRepositories;
using REPOSITORY.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
            _context = context;
            Note = new NoteRepository(_context);
        }

        public INoteRepository Note {  get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsyncChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
