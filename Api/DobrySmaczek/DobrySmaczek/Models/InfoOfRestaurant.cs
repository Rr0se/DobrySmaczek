using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class InfoOfRestaurant
    {
        public int Id { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public double DeliveryCosts { get; set; }
        public double MinOrderAmount { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PhoneNumber { get; set; }

    }
}
