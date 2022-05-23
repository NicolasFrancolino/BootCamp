using System.Linq.Expressions;

namespace PairPro.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
        T findId(Object Id);
       // IEnumerable<T> Find(Expression<Func <T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(Object Id);
        void save(T entity);
        
        // unit of work me permite encapsular las consulta a la base de datos | es un patron de diseño
    }
}
