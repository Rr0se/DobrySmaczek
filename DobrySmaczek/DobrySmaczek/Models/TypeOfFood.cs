using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class TypeOfFood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TypeOfFoods TypeOfFoods { get; set; }
    }

    public enum TypeOfFoods {Kuchnia_Polska, Kuchnia_Włoska, Kuchnia_Turecka, Kuchnia_Japońska, Kuchnia_Amerykańska,
        Pizza, Makarony, Sałatki, Zupy, Sushi, Kanapki, Naleśniki, Desery, Ryby, Owoce_Morza, Pierogi, Burgery, Kebab, Dania_Główne, Przystawki, Zapiekanki}
}
