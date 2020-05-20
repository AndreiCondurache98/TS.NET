using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AspNetCoreWebApp.Models
{
    [DataContract(IsReference = true)]
    public partial class PhotoDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhotoDTO()
        {
            this.People = new List<PersonDTO>();
        }
        [DataMember]
        public int PhotoId { get; set; }

        [DataMember]
        public System.DateTime DateCreated { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Event { get; set; }

        [DataMember]
        public string FilePath { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual List<PersonDTO> People { get; set; }

        [DataMember]
        public virtual LocationDTO Location { get; set; }
    }
}
