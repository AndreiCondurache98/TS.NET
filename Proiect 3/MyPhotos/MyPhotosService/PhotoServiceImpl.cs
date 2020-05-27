using MyPhotosCore.Context;
using MyPhotosCore.Repository.PhotoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosService
{
    public class PhotoServiceImpl : IPhoto
    {
        private static AppModelContainer _context = new AppModelContainer();
        private readonly PhotoRepository photoRepository = new PhotoRepository(_context);

        public PhotoServiceImpl()
        {
        }

        public List<Photo> GetPhotos()
        {
            return photoRepository.GetPhotos();
        }

        public Photo GetPhotoById(int photoId)
        {
            return photoRepository.GetPhotoById(photoId);
        }

        public void AddPhoto(Photo photo)
        {
            photoRepository.AddPhoto(photo);
        }

        public void UpdateLocationOfPhoto(int photoId, Location location)
        {
            photoRepository.UpdateLocationOfPhoto(photoId, location);
        }

        public void DeletePhoto(int photoId)
        {
            photoRepository.DeletePhoto(photoId);
        }

        public bool VerifyPhotoExists(Photo photo)
        {
            return photoRepository.VerifyPhotoExists(photo);
        }

        public List<Photo> GetPhotosOfPerson(Person person)
        {
            return photoRepository.GetPhotosOfPerson(person);
        }

        public List<Photo> GetPhotosOfLocation(Location location)
        {
            return photoRepository.GetPhotosOfLocation(location);
        }

        public void AddPersonToPhoto(Person person, Photo photo)
        {
            photoRepository.AddPersonToPhoto(person, photo);
        }

        public List<Photo> SearchPhotosByEvent(string eveniment)
        {
            return photoRepository.SearchPhotosByEvent(eveniment);
        }

        public List<Photo> SearchPhotosByYear(int year)
        {
            return photoRepository.SearchPhotosByYear(year);
        }

    }
}
