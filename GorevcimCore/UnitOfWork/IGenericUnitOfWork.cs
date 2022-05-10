using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.UnitOfWork
{
    public interface IGenericUnitOfWork
    {
        Task CommitAsync();
        Task Commit();
    }
}
