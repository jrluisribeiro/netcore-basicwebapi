
using archnetcore_microservices_api.models;

namespace archnetcore_microservices_api.services;

public interface IPersonServices { 
    bool create(Person person);
    Person getById(string id);
    bool delete(string id);
    bool update(Person person);
    List<Person> list();
}