using RestWithASPNET10.Models;

namespace RestWithASPNET10.Repositories
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book Update(Book book);
        void Delete(long id);
        Book FindById(long id);
        List<Book> FindAll();
    }
}
