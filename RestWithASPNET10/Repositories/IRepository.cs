using RestWithASPNET10.Models;
using RestWithASPNET10.Models.Base;

namespace RestWithASPNET10.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T Update(T item);
        void Delete(long id);
        T FindById(long id);
        List<T> FindAll();
        bool Exists(long id);
    }
}
