using MyPhotosCore.Context;
using MyPhotosCore.Repository.PersonRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosService
{
    public class PersonServiceImpl : IPerson
    {
        private static AppModelContainer _context = new AppModelContainer();
        private readonly PersonRepository personRepository = new PersonRepository(_context);

        public PersonServiceImpl()
        {
        }

        public List<Person> GetPeople()
        {
            return personRepository.GetPeople();
        }

        public Person GetPerson(int personId)
        {
            return personRepository.GetPerson(personId);
        }

        public void AddPerson(Person person)
        {
            personRepository.AddPerson(person);
        }

        public bool VerifyPersonExists(Person person)
        {
            return personRepository.VerifyPersonExists(person);
        }

        public List<Person> GetPeopleOfPhoto(Photo photo)
        {
            return personRepository.GetPeopleOfPhoto(photo);
        }

        public Person SearchByFullName(string fullName)
        {
            return personRepository.SearchByFullName(fullName);
        }

        public void AddPhotoToPerson(Photo photo, Person person)
        {
            personRepository.AddPhotoToPerson(photo, person);
        }
    }
}
