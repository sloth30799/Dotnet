using REPOSITORY.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        INoteRepository Note { get; }
        Task<int> SaveAsyncChanges();
    }
}
