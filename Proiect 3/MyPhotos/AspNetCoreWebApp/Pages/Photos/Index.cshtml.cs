using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceReferenceLocation;
using ServiceReferencePerson;
using ServiceReferencePhoto;

namespace AspNetCoreWebApp.Pages.Photos
{
    public class IndexModel : PageModel
    {
        PhotoClient photoClient = new PhotoClient();
        PersonClient personClient = new PersonClient();
        LocationClient locationClient = new LocationClient();
        
        public List<PhotoDTO> Photos { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string LocationName { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Year { get; set; }
        public SelectList Names { get; set; }
        public SelectList Years { get; set; }

        public IndexModel()
        {
            Photos = new List<PhotoDTO>();
        }

        public async Task OnGetAsync()
        {
            var photos = await photoClient.GetPhotosAsync();

            var locations = await locationClient.GetLocationsAsync();

            Years = new SelectList((from p in photos
                                    select p.DateCreated.Year).Distinct());

            Names = new SelectList(from l in locations
                                   select l.Name);


            if (!string.IsNullOrEmpty(LocationName))
            {
                var locationFound = await locationClient.SearchByNameAsync(LocationName);
                var photosOfLocation = await photoClient.GetPhotosOfLocationAsync(locationFound);
                photos = photos.Intersect(photosOfLocation, new PhotoComparer()).ToList();
            }
            if (Year != 0)
            {
                var imagesFound = await photoClient.SearchPhotosByYearAsync(Year);
                photos = photos.Intersect(imagesFound, new PhotoComparer()).ToList();
            }

            foreach (var item in photos)
            {
                var peopleInPhoto = await personClient.GetPeopleOfPhotoAsync(item);
                PhotoDTO pd = new PhotoDTO();
                pd.PhotoId = item.PhotoId;
                pd.DateCreated = item.DateCreated;
                pd.Event = item.Event;
                pd.FilePath = item.FilePath;
                pd.Description = item.Description;
                pd.LocationId = item.LocationId;

                foreach (var p in peopleInPhoto)
                {
                    PersonDTO personDTO = new PersonDTO();
                    personDTO.PersonId = p.PersonId;
                    personDTO.FirstName = p.FirstName;
                    personDTO.LastName = p.LastName;
                    pd.People.Add(personDTO);
                }
                Photos.Add(pd);
            }
        }
    }
}