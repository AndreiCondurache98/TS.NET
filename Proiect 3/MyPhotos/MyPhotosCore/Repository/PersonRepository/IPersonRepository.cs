using MyPhotosCore.Context;
using System.Collections.Generic;

namespace MyPhotosCore.Repository.PersonRepository
{
    public interface IPersonRepository
    {
        List<Person> GetPeople();
        Person GetPerson(int personId);
        void AddPerson(Person person);
        bool VerifyPersonExists(Person person);
        List<Person> GetPeopleOfPhoto(Photo photo);
        Person SearchByFullName(string fullName);
        void AddPhotoToPerson(Photo photo, Person person);
    }
}
