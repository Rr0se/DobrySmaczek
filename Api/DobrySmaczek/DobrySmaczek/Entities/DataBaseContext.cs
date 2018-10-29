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

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppOrder> AppOrders { get; set; }
        public DbSet<TypeOfFood> TypeOfFoods { get; set; }
        public DbSet<CategoryFood> CategoryFoods { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<AppOrder> Orders { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<InfoOfRestaurant> InfoOfRestaurants { get; set; }
        public DbSet<UserOrder> UserOrders  { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //----------------Many to Many----------------
            

            modelBuilder.Entity<RestaurantCategoryFood>()
                .HasIndex(u => new { u.RestaurantId, u.CategoryFoodId });

            modelBuilder.Entity<RestaurantCategoryFood>()
                .HasOne(pe => pe.Restaurant)
                .WithMany(p => p.RestaurantCategoryFoods)
                .HasForeignKey(pc => pc.RestaurantId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RestaurantCategoryFood>()
                .HasOne(pe => pe.CategoryFood)
                .WithMany(p => p.RestaurantCategoryFoods)
                .HasForeignKey(pc => pc.CategoryFoodId)
                .OnDelete(DeleteBehavior.Cascade);

            //---------------------------------------------

            modelBuilder.Entity<MenuMeal>()
                .HasIndex(u => new { u.MenuId, u.MealId });

            modelBuilder.Entity<MenuMeal>()
                .HasOne(pe => pe.Menu)
                .WithMany(p => p.MenuMeals)
                .HasForeignKey(pc => pc.MenuId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MenuMeal>()
                .HasOne(pe => pe.Meal)
                .WithMany(p => p.MenuMeals)
                .HasForeignKey(pc => pc.MealId)
                .OnDelete(DeleteBehavior.Cascade);

            //---------------------------------------------

            modelBuilder.Entity<MenuTypeOfFood>()
                .HasIndex(u => new { u.MenuId, u.TypeOfFoodId });

            modelBuilder.Entity<MenuTypeOfFood>()
                .HasOne(pe => pe.Menu)
                .WithMany(p => p.MenuTypeOfFoods)
                .HasForeignKey(pc => pc.MenuId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MenuTypeOfFood>()
                .HasOne(pe => pe.TypeOfFood)
                .WithMany(p => p.MenuTypeOfFoods)
                .HasForeignKey(pc => pc.TypeOfFoodId)
                .OnDelete(DeleteBehavior.Cascade);

            //--------------- One to Many------------------
            
            modelBuilder.Entity<Restaurant>()
                .HasMany(rev => rev.Reviews)
                .WithOne(res => res.Restaurant);

            //modelBuilder.Entity<UserOrder>()
            //    .HasMany(ord => ord.Orders)
            //    .WithOne(usr => usr.User);

            //----------------One to One ------------------

            modelBuilder.Entity<Restaurant>()
                .HasOne(me => me.Menu)
                .WithOne(res => res.Restaurant);

            //---------------------------------------------


        }
    }
    
}
