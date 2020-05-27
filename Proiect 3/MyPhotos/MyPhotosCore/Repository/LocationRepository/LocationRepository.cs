using MyPhotosCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosCore.Repository.LocationRepository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly AppModelContainer _context;

        public LocationRepository(AppModelContainer context)
        {
            _context = context;
        }
        public List<Location> GetLocations()
        {
            return _context.Locations.ToList();
        }
        public bool VerifyLocationExists(Location location)
        {
            if (location == null) return false;
            var locationFound = _context.Locations.FirstOrDefault(l => l.LocationId == location.LocationId);
            return location != null;
        }
        public void AddLocation(Location location)
        {
            if (VerifyLocationExists(location)) return;
            _context.Locations.Add(location);
            _context.SaveChanges();
        }
        public Location SearchByName(string locationName)
        {
            if (locationName == null) return null;
            Location locationFound = _context.Locations.FirstOrDefault(l => l.Name.ToLower() == locationName.ToLower());

            if (VerifyLocationExists(locationFound)) return locationFound;
            return null;
        }
        
    }
}
