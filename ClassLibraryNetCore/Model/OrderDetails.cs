using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibraryNetCore.Model
{
    public partial class OrderDetails
    {
        [Key]
        public int OrderDetailId { get; set; }
        
        [MaxLength(20)]
        public string NameOfStore { get; set; }
        
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
