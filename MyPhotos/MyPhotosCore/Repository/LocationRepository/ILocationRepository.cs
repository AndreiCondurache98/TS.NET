using MyPhotosCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosCore.Repository.LocationRepository
{
    public interface ILocationRepository
    {
        List<Location> GetLocations();
        void AddLocation(Location location);
        bool VerifyLocationExists(Location location);
        Location SearchByName(string locationName);

    }
}
