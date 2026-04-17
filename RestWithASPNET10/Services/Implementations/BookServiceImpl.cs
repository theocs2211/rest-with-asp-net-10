using Mapster;
using RestWithASPNET10.Data.DTO.V1;
using RestWithASPNET10.Models;
using RestWithASPNET10.Repositories;

namespace RestWithASPNET10.Services.Implementations
{
    public class BookServiceImpl : IBookService
    {
        private IRepository<Book> _repository;

        public BookServiceImpl(IRepository<Book> repository) 
        { 
            _repository = repository;
        }


        public BookDTO FindById(long id)
        {
            return _repository.FindById(id).Adapt<BookDTO>();
        }

        public List<BookDTO> FindAll()
        {
            return _repository.FindAll().Adapt<List<BookDTO>>();
        }

        public BookDTO Create(BookDTO book)
        {
            var entity = book.Adapt<Book>();
            entity = _repository.Create(entity);
            return entity.Adapt<BookDTO>();
        }

        public BookDTO Update(BookDTO book)
        {
            var entity = book.Adapt<Book>();
            entity = _repository.Update(entity);
            return entity.Adapt<BookDTO>();
        }

        public void Delete(long id)
        {
            _repository.Delete(id); 
        }
    }
}
