using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace AspNetCoreWebApp.Models
{
    [DataContract(IsReference = true)]
    public partial class LocationDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocationDTO()
        {
            this.Photos = new List<PhotoDTO>();
        }
        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<PhotoDTO> Photos { get; set; }
    }
}
