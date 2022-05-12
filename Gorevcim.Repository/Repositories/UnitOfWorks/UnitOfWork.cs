using Gorevcim.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Repositories.UnitOfWorks
{
    public class UnitOfWork : IGenericUnitOfWork
    {
        private readonly AppDbContext.AppDbContext _context;

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
