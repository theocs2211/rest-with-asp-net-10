using Mapster;
using RestWithASPNET10.Data.Converter.Impl;
using RestWithASPNET10.Data.DTO;
using RestWithASPNET10.Models;
using RestWithASPNET10.Repositories;

namespace RestWithASPNET10.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        private IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonServiceImpl(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonDTO FindById(long id)
        {
            return _repository.FindById(id).Adapt<PersonDTO>();
        }

        public List<PersonDTO> FindAll()
        {
            return _repository.FindAll().Adapt<List<PersonDTO>>();
        }

        public PersonDTO Create(PersonDTO person)
        {
            var entity = person.Adapt<Person>();
            entity = _repository.Create(entity);
            return entity.Adapt<PersonDTO>();
        }

        public PersonDTO Update(PersonDTO person)
        {
            var entity = person.Adapt<Person>();
            entity = _repository.Update(entity);
            return entity.Adapt<PersonDTO>();
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
