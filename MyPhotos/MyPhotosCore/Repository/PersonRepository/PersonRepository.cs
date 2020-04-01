using MyPhotosCore.Context;
using System.Collections.Generic;
using System.Linq;

namespace MyPhotosCore.Repository.PersonRepository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppModelContainer _context;

        public PersonRepository(AppModelContainer context)
        {
            _context = context;
        }
        public List<Person> GetPeople()
        {
            return _context.People.ToList();
        }

        public bool VerifyPersonExists(Person person)
        {
            if (person == null) return false;
            Person personFound = _context.People.FirstOrDefault(p => p.PersonId == person.PersonId);
            return personFound != null;
        }
        public Person GetPerson(int personId)
        {
            var personFound = _context.People.FirstOrDefault(p => p.PersonId == personId);
            if (VerifyPersonExists(personFound)) return personFound;
            return null;
        }
        public List<Person> GetPeopleOfPhoto(Photo photo)
        {
            if (photo == null) return null;
            var query = from person in _context.People
                        where person.Photos.Any(p => p.PhotoId == photo.PhotoId)
                        select person;
            return query.ToList();
        }
        public void AddPerson(Person person)
        {
            if (VerifyPersonExists(person)) return;
            _context.People.Add(person);
            _context.SaveChanges();
        }

        public Person SearchByFullName(string fullName)
        {
            if(fullName == null) return null;

            string[] words = fullName.Split(' ');
            string firstName = words[0];
            string lastName = words[1];
            Person personSearched = _context.People.FirstOrDefault(p => (p.FirstName == firstName) && (p.LastName == lastName));
            if (VerifyPersonExists(personSearched)) return personSearched;
            return null;
        }

        public void AddPhotoToPerson(Photo photo, Person person)
        {
            var photoFound = _context.Photos.FirstOrDefault(ph => ph.PhotoId == photo.PhotoId);
            var personFound = _context.People.FirstOrDefault(p => p.PersonId == person.PersonId);
            personFound.Photos.Add(photoFound);
            _context.SaveChanges();
        }

    }
}
