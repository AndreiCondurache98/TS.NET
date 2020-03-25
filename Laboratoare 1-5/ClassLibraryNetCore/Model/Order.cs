﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibraryNetCore.Model
{
    public partial class Order
    {
        [Key]
        public int OrderId { get; set; }
     
        [MaxLength(20)]
        public string Description { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DateOrdered { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }

        protected Order() { }
    }
}
