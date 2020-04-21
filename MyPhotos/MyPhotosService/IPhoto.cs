using System.Collections.Generic;
using System.ServiceModel;
using MyPhotosCore.Context;

namespace MyPhotosService
{
    [ServiceContract]
    public interface IPhoto
    {
        [OperationContract]
        List<Photo> GetPhotos();

        [OperationContract]
        Photo GetPhotoById(int photoId);

        [OperationContract]
        void AddPhoto(Photo photo);

        [OperationContract]
        void UpdateLocationOfPhoto(int photoId, Location location);

        [OperationContract]
        void DeletePhoto(int photoId);

        [OperationContract]
        bool VerifyPhotoExists(Photo photo);

        [OperationContract]
        List<Photo> GetPhotosOfPerson(Person person);

        [OperationContract]
        List<Photo> GetPhotosOfLocation(Location location);

        [OperationContract]
        void AddPersonToPhoto(Person person, Photo photo);

        [OperationContract]
        List<Photo> SearchPhotosByEvent(string eveniment);

        [OperationContract]
        List<Photo> SearchPhotosByYear(int year);
    }
}
