using Microsoft.EntityFrameworkCore;
using RestWithASPNET10.Models.Base;
using RestWithASPNET10.Models.Context;

namespace RestWithASPNET10.Repositories.Implementations
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MSSQLContext _context;
        private DbSet<T> _dataset;
        public GenericRepository(MSSQLContext context)
        {
            _context = context;
            _dataset = context.Set<T>();
        }

        public T FindById(long id)
        {
            return _dataset.Find(id);
        }
        public List<T> FindAll()
        {
            return _dataset.ToList();
        }
        public T Create(T item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }
        public T Update(T item)
        {
            var existingitem = _dataset.Find(item.Id);
            if (existingitem == null)
            {
                return null;
            }
            _context.Entry(existingitem).CurrentValues.SetValues(item);
            _context.SaveChanges();
            return item;
        }
        public void Delete(long id)
        {
            var existingitem = _dataset.Find(id);
            if (existingitem == null)
            {
                return;
            }
            _dataset.Remove(existingitem);
            _context.SaveChanges();
        }
        public bool Exists(long id)
        {
            return _dataset.Any(e => e.Id == id);
        }
    }
}
