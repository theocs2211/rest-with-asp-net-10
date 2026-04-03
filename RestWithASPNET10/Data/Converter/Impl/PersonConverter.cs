using RestWithASPNET10.Data.Converter.Contract;
using RestWithASPNET10.Data.DTO;
using RestWithASPNET10.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNET10.Data.Converter.Impl
{
    public class PersonConverter : IParser<PersonDTO, Person>, IParser<Person, PersonDTO>
    {
        public Person Parse(PersonDTO origin)
        {
            if (origin == null) return null;
            return new Person
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender
            };
        }
        public PersonDTO Parse(Person origin)
        {
            if (origin == null) return null;
            return new PersonDTO
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender
            };
        }

        public List<Person> ParseList(List<PersonDTO> originList)
        {
            if (originList == null) return null;
            return originList.Select(item => Parse(item)).ToList();
        }



        public List<PersonDTO> ParseList(List<Person> originList)
        {
            if (originList == null) return null;
            return originList.Select(item => Parse(item)).ToList();
        }
    }
}
