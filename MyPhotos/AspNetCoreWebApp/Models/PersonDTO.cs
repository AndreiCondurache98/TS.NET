using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AspNetCoreWebApp.Models
{
    [DataContract(IsReference = true)]
    public partial class PersonDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonDTO()
        {
            this.Photos = new List<PhotoDTO>();
        }
        [DataMember]
        public int PersonId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<PhotoDTO> Photos { get; set; }
    }
}
