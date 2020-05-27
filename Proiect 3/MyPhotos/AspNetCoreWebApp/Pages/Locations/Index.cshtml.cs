using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceLocation;
using ServiceReferencePhoto;

namespace AspNetCoreWebApp.Pages.Locations
{
    public class IndexModel : PageModel
    {
        LocationClient locationClient = new LocationClient();
        PhotoClient photoClient = new PhotoClient();
        public List<LocationDTO> Locations { get; set; }

        public IndexModel()
        {
            Locations = new List<LocationDTO>();
        }

        public async Task OnGetAsync()
        {
            var locations = await locationClient.GetLocationsAsync();

            foreach(var item in locations)
            {
                var photos = await photoClient.GetPhotosOfLocationAsync(item);
                LocationDTO ld = new LocationDTO();
                ld.LocationId = item.LocationId;
                ld.Name = item.Name;
                foreach(var p in photos)
                {
                    PhotoDTO photoDTO = new PhotoDTO();
                    photoDTO.PhotoId = p.PhotoId;
                    photoDTO.LocationId = p.LocationId;
                    photoDTO.Event = p.Event;
                    photoDTO.DateCreated = p.DateCreated;
                    photoDTO.Description = p.Description;
                    ld.Photos.Add(photoDTO);
                }
                Locations.Add(ld);
            }
        }
    }
}