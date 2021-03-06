﻿using System.Collections.Generic;
using System.ServiceModel;
using MyPhotosCore.Context;

namespace MyPhotosService
{
    [ServiceContract]
    public interface ILocation
    {
        [OperationContract]
        List<Location> GetLocations();

        [OperationContract]
        void AddLocation(Location location);

        [OperationContract]
        bool VerifyLocationExists(Location location);

        [OperationContract]
        Location SearchByName(string locationName);
    }
}
