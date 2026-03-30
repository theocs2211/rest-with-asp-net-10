using RestWithASPNET10.Models;

namespace RestWithASPNET10.Services
{
    public interface IBookService
    {
        Book Create(Book book);
        Book Update(Book book);
        void Delete(long id);
        Book FindById(long id);
        List<Book> FindAll();
    }
}
