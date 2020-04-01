using MyPhotosCore.Context;
using System.Collections.Generic;
using System.Linq;

namespace MyPhotosCore.Repository.PhotoRepository
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly AppModelContainer _context;

        public PhotoRepository(AppModelContainer context)
        {
            _context = context;
        }
        public List<Photo> GetPhotos()
        {
            return _context.Photos.ToList();
        }
        public Photo GetPhotoById(int photoId)
        {
            var photoFound = _context.Photos.FirstOrDefault(p => p.PhotoId == photoId);
            if (VerifyPhotoExists(photoFound)) return photoFound;
            return null;
        }

        public bool VerifyPhotoExists(Photo photo)
        {
            if (photo == null) return false;
            Photo photoFound = _context.Photos.FirstOrDefault(p => p.PhotoId == photo.PhotoId);
            return photoFound != null;
        }
        public void AddPhoto(Photo photo)
        {
            if (VerifyPhotoExists(photo)) return;
            _context.Photos.Add(photo);
            _context.SaveChanges();
        }

        public void DeletePhoto(int photoId)
        {
            var photo = _context.Photos.FirstOrDefault(p => p.PhotoId == photoId);
            if (!VerifyPhotoExists(photo)) return;
            
            foreach(var person in photo.People)
            {
                person.Photos.Remove(photo);
            }
            _context.Photos.Remove(photo);
            _context.SaveChanges();      
        }

        public List<Photo> GetPhotosOfPerson(Person person)
        {
            if (person == null) return null;
            var query = from photo in _context.Photos
                        where photo.People.Any(p => p.PersonId == person.PersonId)
                        select photo;
            return query.ToList();
        }
        public List<Photo> GetPhotosOfLocation(Location location)
        {
            if (location == null) return null;
            var query = from photo in _context.Photos
                        where photo.Location.LocationId == location.LocationId
                        select photo;
            return query.ToList();
        }
        public void AddPersonToPhoto(Person person, Photo photo)
        {
            var photoFound = _context.Photos.FirstOrDefault(ph => ph.PhotoId == photo.PhotoId);
            var personFound = _context.People.FirstOrDefault(p => p.PersonId == person.PersonId);
            photoFound.People.Add(personFound);
            _context.SaveChanges();
        }

        public List<Photo> SearchPhotosByEvent(string eveniment)
        {
            var photosFound = _context.Photos.Where(p => p.Event.ToLower() == eveniment.ToLower());
            return photosFound.ToList();
        }
        public List<Photo> SearchPhotosByYear(int year)
        {
            var photosFound = _context.Photos.Where(p => p.DateCreated.Year == year);
            return photosFound.ToList();
        }
        public void UpdateLocationOfPhoto(int photoId, Location location)
        {
            Photo photoFound = _context.Photos.FirstOrDefault(p => p.PhotoId == photoId);
            
            photoFound.Location = location;
            photoFound.LocationId = location.LocationId;
            
            _context.SaveChanges();
        }

    }
}
