using Mapster;
using RestWithASPNET10.Data.Converter.Impl;
using RestWithASPNET10.Data.DTO.V2;
using RestWithASPNET10.Models;
using RestWithASPNET10.Repositories;

namespace RestWithASPNET10.Services.Implementations
{
    public class PersonServiceImplV2
    {
        private IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonServiceImplV2(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonDTO Create(PersonDTO person)
        {
            var entity = _converter.Parse(person);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }
    }
}
