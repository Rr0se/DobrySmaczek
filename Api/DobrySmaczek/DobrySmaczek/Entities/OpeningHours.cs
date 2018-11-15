using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class OpeningHours
    {
        public int Id { get; set; }
        public Restaurant Restaurant { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
    }
}
