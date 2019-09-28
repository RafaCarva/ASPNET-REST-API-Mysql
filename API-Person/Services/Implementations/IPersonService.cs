using API_Person.Model;
using System.Collections.Generic;

namespace API_Person.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FinidAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
