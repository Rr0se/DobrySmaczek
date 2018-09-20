using DobrySmaczek.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
             : base(options)
        {
            //Database.Migrate();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TypeOfFood> TypeOfFoods { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<InfoOfRestaurant> InfoOfRestaurants { get; set; }

    }
}
