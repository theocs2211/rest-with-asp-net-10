using RestWithASPNET10.Models;
using RestWithASPNET10.Models.Context;
using RestWithASPNET10.Repositories;
using RestWithASPNET10.Repositories.Implementations;

namespace RestWithASPNET10.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        private readonly IPersonRepository _repository;

        public PersonServiceImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
