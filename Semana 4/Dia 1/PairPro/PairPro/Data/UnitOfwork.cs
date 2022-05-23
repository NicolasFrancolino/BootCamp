using Microsoft.EntityFrameworkCore;
using PairPro.Repository;
using System.Data.Entity;

namespace PairPro.Data
{
    public class UnitOfwork<TContext> : IUnitOfwork<TContext>, IDisposable where TContext : DbContext, new()
    {
        private readonly TContext _context;
        private bool _disposed;
        private string errorMessage = string.Empty;
        private DbContextTransaction dbContextTrans;
        private Dictionary<string, object> dictionary;

        public UnitOfwork()
        {
            _context = new TContext();
        }

        public void Dispose() //libera rescursos no administrados por ejemplo tener un hilo abierto sin uso... 
        {
            Dispose(true); // seteo el valor
            GC.SuppressFinalize(this); //me permite mandar a ejecutar el dispose
        }
        public TContext context()
        {
            get{ return _context; }
        }

        public void Commit()
        {
            dbContextTrans.Commit();
        }
        public void Rollback()
        {
            dbContextTrans.Rollback();
            dbContextTrans.Dispose();
        }

        public void SavePoint()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        protected virtual void Dispose(bool T_type)
        {
            if (!_disposed)
            {
                if (T_type)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }
        public GenericRepository<T> genericRepository<T>() where T : class
        {
            if (dictionary == null)
            {
                dictionary = new Dictionary<string, object>(); 
            }
            var type = typeof(T).Name;
            if (!dictionary.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<T>);
                var InstanciaRepo = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)),_context);
            
            }
            return (GenericRepository<T>)_repositories[type];
        }

    }
}
