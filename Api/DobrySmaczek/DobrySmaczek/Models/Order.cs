using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class Order
    {

        public int Id { get; set; }
        [Required]
        public string User { get; set; }
        // Navigation property
        public ICollection<OrderDetail> OrderDetails { get; set; }
       
    }
}
