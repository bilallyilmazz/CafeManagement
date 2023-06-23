using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
        void Commit();

    }
}
