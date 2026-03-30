using RestWithASPNET10.Models;
using RestWithASPNET10.Repositories;

namespace RestWithASPNET10.Services.Implementations
{
    public class BookServiceImpl : IBookService
    {
        private IBookRepository _repository;

        public BookServiceImpl(IBookRepository repository) 
        { 
            _repository = repository;
        }


        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id); 
        }
    }
}
