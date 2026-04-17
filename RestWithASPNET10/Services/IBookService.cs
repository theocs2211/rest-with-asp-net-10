using RestWithASPNET10.Data.DTO.V1;
using RestWithASPNET10.Models;

namespace RestWithASPNET10.Services
{
    public interface IBookService
    {
        BookDTO Create(BookDTO book);
        BookDTO Update(BookDTO book);
        void Delete(long id);
        BookDTO FindById(long id);
        List<BookDTO> FindAll();
    }
}
