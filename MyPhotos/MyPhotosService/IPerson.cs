using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MyPhotosCore.Context;

namespace MyPhotosService
{
    [ServiceContract]
    public interface IPerson
    {
        [OperationContract]
        List<Person> GetPeople();

        [OperationContract]
        Person GetPerson(int personId);

        [OperationContract]
        void AddPerson(Person person);

        [OperationContract]
        bool VerifyPersonExists(Person person);

        [OperationContract]
        List<Person> GetPeopleOfPhoto(Photo photo);

        [OperationContract]
        Person SearchByFullName(string fullName);

        [OperationContract]
        void AddPhotoToPerson(Photo photo, Person person);

    }
}
