using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePerson;
using ServiceReferencePhoto;

namespace AspNetCoreWebApp.Pages.People
{
    public class ListModel : PageModel
    {
        PhotoClient photoClient = new PhotoClient();
        PersonClient personClient = new PersonClient();
        public List<PersonDTO> People { get; set; }

        public ListModel()
        {
            People = new List<PersonDTO>();
        }
        public async Task OnGetAsync(int? id)
        {
            if (!id.HasValue)
                return;

            var item = await photoClient.GetPhotoByIdAsync(id.Value);
            var peopleInPhoto = await personClient.GetPeopleOfPhotoAsync(item);

            ViewData["Photo"] = item.PhotoId.ToString();
            foreach(var p in peopleInPhoto)
            {
                PersonDTO personDTO = new PersonDTO();
                personDTO.PersonId = p.PersonId;
                personDTO.FirstName = p.FirstName;
                personDTO.LastName = p.LastName;
                People.Add(personDTO);
            }
        }

    }
}