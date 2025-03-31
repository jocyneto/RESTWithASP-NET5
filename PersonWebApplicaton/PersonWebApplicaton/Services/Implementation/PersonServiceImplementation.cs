using PersonWebApplicaton.Model;
using PersonWebApplicaton.Model.Context;

namespace PersonWebApplicaton.Services.Implemenatation;

public class PersonServiceImplementation : IPersonService
{
    private SQLServerConxtext _context;
    public PersonServiceImplementation(SQLServerConxtext context)
    {
        _context = context;
    }

    public Person Create(Person person)
    {
        throw new NotImplementedException();
    }

    public void Delete(long id)
    {
        throw new NotImplementedException();
    }

    public List<Person> GetAll()
    {
        return _context.Persons.ToList();
    }

    public Person GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Person Update(Person person)
    {
        throw new NotImplementedException();
    }
}
