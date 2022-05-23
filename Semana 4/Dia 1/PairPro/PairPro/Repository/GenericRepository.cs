using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairPro.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public DbContext _context = null;
        public DbSet<T> table= null;
        
        public GenericRepository(DbContext context)
        {
           _context = context;
            table = _context.Set<T>();
        }
        public GenericRepository()
        {
            //this._context = new DbContext();
        }

        // IQueryable devuelve una lista que se puede filtrar.... no es recomendable

        //IEnumerable<T> query = _context.Set<T>().Where(predicate);

        public IEnumerable<T> GetAll() => table.ToList();
        public T findId(Object Id) => table.Find(Id);



        public void Add(T entity)
        {
            table.Add(entity);
        }

        public void Update(T entity)
        {
            table.Attach(entity);//traigo los nuevos valores 
            _context.Entry(entity).State = EntityState.Modified;   
        }

        public void Delete(Object Id)
        {
            T entity = table.Find(Id);
            table.Remove(entity);
            
        }

        public void save(T entity)
        {
            _context.SaveChanges();
        }
    }
}
