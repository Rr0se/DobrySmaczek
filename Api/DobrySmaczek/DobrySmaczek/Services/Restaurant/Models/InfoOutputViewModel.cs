using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Restaurant.Models
{
    public class InfoOutputViewModel
    {
        public IList<OpeningViewModel> OpeningViewModel { get; set; }
        public LocationViewModel LocationViewModel { get; set; }
        public double EstimatedDeliveryTime { get; set; }
        public double MinOrderAmount { get; set; }
        public double DeliveryCosts { get; set; }
    }

    public class OpeningViewModel
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public bool IsCurrent { get; set; }
    }

    public class LocationViewModel
    {
        public string Address { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
    }
}
