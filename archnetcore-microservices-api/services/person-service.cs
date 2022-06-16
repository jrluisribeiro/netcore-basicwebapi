
using System.Diagnostics;
using archnetcore_microservices_api.models;

namespace archnetcore_microservices_api.services;

public class PersonService : IPersonServices
{
    public List<Person> mockPerson()
    {
        return new List<Person>()
        {
            new Person(){ id = "6eba1c4d184b", firstName= "Legalzinho",lastName = "Feliz", birthDate= Convert.ToDateTime("1941-05-13") },
            new Person(){ id = "37dfc58f9540", firstName= "Joinha",lastName = "Maroto", birthDate= Convert.ToDateTime("1994-07-12") },
            new Person(){ id = "239a8dd3e62f", firstName= "Pagode",lastName = "Maravilha", birthDate= Convert.ToDateTime("1953-08-25") }
        };
    }

    public bool create(Person person)
    {
        Debug.WriteLine(person);
        return true;
    }

    public bool delete(string id) { throw new NotImplementedException(); }

    public Person getById(string id) { return this.mockPerson().Where(a => a.id == id).FirstOrDefault(); }
    public List<Person> list() { return this.mockPerson(); }

    public bool update(Person person)
    {
        Debug.WriteLine(person);
        return true;
    }
}