using RestWithASPNET10.Models;

namespace RestWithASPNET10.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        public Person FindById(long id)
        {
            return new Person
            {
                Id = id,
                FirstName = "Théo " + id,
                LastName = "da Cruz de Souza",
                Address = "Rua Marcilio Dias",
                Gender = "Male"
            };
        }

        public List<Person> FindAll()
        {
            List<Person> list = new List<Person>();

            list.Add(new Person
            {
                Id = new Random().Next(1, 1000),
                FirstName = "Théo",
                LastName = "da Cruz de Souza",
                Address = "Rua Marcilio Dias",
                Gender = "Male"
            });
            list.Add(new Person
            {
                Id = new Random().Next(1, 1000),
                FirstName = "Daniel",
                LastName = "Pires de Souza",
                Address = "Rua Marcilio Dias",
                Gender = "Male"
            });

            return list;
        }

        public Person Create(Person person)
        {
            return person;
        }

        public Person Update(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            //deletion logic
        }
    }
}
