using Microsoft.EntityFrameworkCore;

namespace WebApp.Code.Repository
{
    public class GenericRepository : IGenericRepository<T> where T : class
    {

    
        private readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }
        public void add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void UpDate(T entity)
        {

        }


    }
}
