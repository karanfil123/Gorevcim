using Gorevcim.Core.UnitOfWork;

namespace Gorevcim.Repository.Repositories.UnitOfWorks
{
    public class UnitOfWork : IGenericUnitOfWork
    {
        private readonly AppDbContext.AppDbContext _context;

        public UnitOfWork(AppDbContext.AppDbContext context)
        {
            _context = context;
        }

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
