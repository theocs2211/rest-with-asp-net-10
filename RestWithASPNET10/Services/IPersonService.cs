using RestWithASPNET10.Data.DTO;

namespace RestWithASPNET10.Services
{
    public interface IPersonService
    {
        PersonDTO Create(PersonDTO PersonDTO);
        PersonDTO Update(PersonDTO PersonDTO);
        void Delete(long id);
        PersonDTO FindById(long id);
        List<PersonDTO> FindAll();
    }
}
