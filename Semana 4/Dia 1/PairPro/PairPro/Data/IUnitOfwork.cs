using Microsoft.EntityFrameworkCore;

namespace PairPro.Data
{
    public interface IUnitOfwork<out TContext> where TContext : DbContext, new()
    {
        TContext context { get;}
        void Commit();
        void Rollback();
        void SavePoint();
        void CreateTransaction();
    }
}
