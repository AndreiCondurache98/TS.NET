using MyPhotosCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosCore.Repository.PhotoRepository
{
    public interface IPhotoRepository
    {
        List<Photo> GetPhotos();
        Photo GetPhotoById(int photoId);
        void AddPhoto(Photo photo);
        void UpdateLocationOfPhoto(int photoId, Location location);
        void DeletePhoto(int photoId);
        bool VerifyPhotoExists(Photo photo);
        List<Photo> GetPhotosOfPerson(Person person);
        List<Photo> GetPhotosOfLocation(Location location);
        void AddPersonToPhoto(Person person, Photo photo);
        List<Photo> SearchPhotosByEvent(string eveniment);
        List<Photo> SearchPhotosByYear(int year);

    }
}
