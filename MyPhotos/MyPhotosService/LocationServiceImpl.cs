using MyPhotosCore.Context;
using MyPhotosCore.Repository.LocationRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosService
{
    public class LocationServiceImpl : ILocation
    {
        private static AppModelContainer _context = new AppModelContainer();
        private readonly LocationRepository locationRepository = new LocationRepository(_context);

        public LocationServiceImpl()
        {

        }
        public List<Location> GetLocations()
        {
            return locationRepository.GetLocations();
        }

        public void AddLocation(Location location)
        {
            locationRepository.AddLocation(location);
        }

        public bool VerifyLocationExists(Location location)
        {
            return locationRepository.VerifyLocationExists(location);
        }

        public Location SearchByName(string locationName)
        {
            return locationRepository.SearchByName(locationName);
        }
    }
}
