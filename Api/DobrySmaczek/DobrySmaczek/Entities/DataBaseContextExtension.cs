using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DobrySmaczek.Entities
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<DataBaseContext>();
            context.Database.EnsureCreated();
            if (!context.AppUsers.Any())
            {
                try
                {
                    var users = new List<AppUser>()
                    {
                        new AppUser(){FirstName = "Jan", LastName = "Kowalski" , Email = "JanKowalski@gmail.com", PhoneNumber = "123456789",  UserType=UserType.User} ,
                        new AppUser(){FirstName = "Anna", LastName = "Lubińska" , Email = "AnnaLubi@gmail.com", PhoneNumber = "555444333",  UserType=UserType.User} ,
                        new AppUser(){FirstName = "Marta", LastName = "Mazurkiewicz", Email = "Marta.Mazurkiewicz94@gmail.com", PhoneNumber = "333666555",  UserType=UserType.User} ,
                        new AppUser(){FirstName = "Marcin", LastName = "Starostecki", Email = "Marcin_Starostec@gmail.com", PhoneNumber = "222333444",UserType=UserType.User} ,
                        new AppUser(){FirstName = "Paweł", LastName = "Stryjewski", Email = "PawelStryju@gmail.com", PhoneNumber = "777555444",  UserType=UserType.User} ,
                        new AppUser(){FirstName = "Damian", LastName = "Wiewióra", Email = "Damian_Wiewiora@gmail.com", PhoneNumber = "999777666",  UserType=UserType.User} ,
                        new AppUser(){FirstName = "Alex", LastName = "Mazurkiewicz", Email = "AlexMazur@gmail.com", PhoneNumber = "666544455",  UserType=UserType.User} ,
                        new AppUser(){FirstName = "Krystyna", LastName = "Gonera", Email = "KrystynaGonera45@gmail.com", PhoneNumber = "898070505",  UserType=UserType.User} ,
                        new AppUser(){FirstName = "Krzysztof", LastName = "Jaszczołt", Email = "KrzysiuJaszcz@gmail.com", PhoneNumber = "674839475",  UserType=UserType.User} ,
                        new AppUser(){FirstName = "Adrianna", LastName = "Jeznach", Email = "JeznachAdrianna@gmail.com", PhoneNumber = "930485748",  UserType=UserType.User} ,
                        new AppUser(){FirstName = "Michał", LastName = "Prosiak", Email = "Prosiaczek123@gmail.com", PhoneNumber = "853847323",  UserType=UserType.User}

                    };

                    var typeoffoods = new List<TypeOfFood>()
                    {
                        new TypeOfFood(){Name="Burgery"},
                        new TypeOfFood(){Name="Sałatki"},
                        new TypeOfFood(){Name="Pizza"},
                        new TypeOfFood(){Name="Dania główne"},
                        new TypeOfFood(){Name="Zupy"},
                        new TypeOfFood(){Name="Zapiekanki"},
                        new TypeOfFood(){Name="Przystawki"},
                        new TypeOfFood(){Name="Desery"},
                        new TypeOfFood(){Name="Pierogi"},
                        new TypeOfFood(){Name="Naleśniki"},
                        new TypeOfFood(){Name="Makarony"},
                        new TypeOfFood(){Name="Syshi"},
                        new TypeOfFood(){Name="Kanapki"},
                        new TypeOfFood(){Name="Ryby"},
                        new TypeOfFood(){Name="Owoce Morza"},
                        new TypeOfFood(){Name="Kebaby"},
                        new TypeOfFood(){Name="Dodatki"},
                        new TypeOfFood(){Name="Koktajle"},
                        new TypeOfFood(){Name="Napoje zimne"},
                        new TypeOfFood(){Name="Napoje Gorące"},


                        new TypeOfFood(){Name="Kuchnia Polska"},
                        new TypeOfFood(){Name="Kuchnia Włoska"},
                        new TypeOfFood(){Name="Kuchania Amerykańska"},
                        new TypeOfFood(){Name="Kuchnia Turecka"},
                        new TypeOfFood(){Name="Kuchnia Japońska"},
                        new TypeOfFood(){Name="Kuchnia Wegetariańska"}
                      
                    };

                    var categoryfood = new List<CategoryFood>()
                    {

                        new CategoryFood(){Name="Burgery"},
                        new CategoryFood(){Name="Sałatki"},
                        new CategoryFood(){Name="Pizza"},
                        new CategoryFood(){Name="Dania główne"},
                        new CategoryFood(){Name="Zupy"},
                        new CategoryFood(){Name="Zapiekanki"},
                        new CategoryFood(){Name="Przystawki"},
                        new CategoryFood(){Name="Desery"},
                        new CategoryFood(){Name="Pierogi"},
                        new CategoryFood(){Name="Naleśniki"},
                        new CategoryFood(){Name="Makarony"},
                        new CategoryFood(){Name="Syshi"},
                        new CategoryFood(){Name="Kanapki"},
                        new CategoryFood(){Name="Ryby"},
                        new CategoryFood(){Name="Owoce Morza"},
                        new CategoryFood(){Name="Kebaby"},
                        new CategoryFood(){Name="Dodatki"},
                        new CategoryFood(){Name="Koktajle"},
                        new CategoryFood(){Name="Napoje zimne"},
                        new CategoryFood(){Name="Napoje Gorące"},


                        new CategoryFood(){Name="Kuchnia Polska"},
                        new CategoryFood(){Name="Kuchnia Włoska"},
                        new CategoryFood(){Name="Kuchania Amerykańska"},
                        new CategoryFood(){Name="Kuchnia Turecka"},
                        new CategoryFood(){Name="Kuchnia Japońska"},
                        new CategoryFood(){Name="Kuchnia Wegetariańska"}
                    };


                    var meals = new List<Meal>()
                    {
                        new Meal(){Name="Burger",Components="Bułka,Mięso wołowe 100%, sałata, pomidor, ogórek, sosy",Price=12, TypeOfFood=typeoffoods[0] },
                        new Meal(){ Name="Zapiekanka",Components="Bułka,szynka,ser,sos",Price=5, TypeOfFood=typeoffoods[5]},
                        new Meal(){ Name="Sałatka Grecka",Components="Sałata,Pomidor,Ogórek,Oliwki,Cebula,Ser Feta",Price=10, TypeOfFood=typeoffoods[1]},
                        new Meal(){ Name="Pizza Capriciosa",Components="Ciasto,Sos,Ser,Szybka,Pieczarki",Price=22, TypeOfFood=typeoffoods[2]},
                        new Meal(){ Name="Shoarma Klasyczna",Components="Pierś z kurczaka,Frytki,Pita,Zestaw surówek",Price=20, TypeOfFood=typeoffoods[3]},
                        new Meal(){ Name="Filet z Puree",Components="Filet z kurczaka, Puree ziemniaczane, zestaw surówek",Price=15, TypeOfFood=typeoffoods[3]},
                        new Meal(){ Name="Grochówka",Components="Zupa: groch,ziemniaki, marchew, pietruszka",Price=5, TypeOfFood=typeoffoods[4]},
                        new Meal(){ Name="Chlebek Czosnkowy",Components="Chlebek, masło, czosnek",Price=5, TypeOfFood=typeoffoods[6]},
                        new Meal(){ Name="Sernik",Components="Sernik z rodzynkami, polewa czekoladowa",Price=8, TypeOfFood=typeoffoods[7]},
                        new Meal(){ Name="Pierogi z mięsem",Components="Pierogi z mięsem, cebula zasmażana",Price=10, TypeOfFood=typeoffoods[8]},
                        new Meal(){ Name="Naleśniki ze szpinakiem",Components="Naleśniki, farsz szpinakowy, sos śmietanowy",Price=10, TypeOfFood=typeoffoods[9]}
                    };

                    var restaurants = new List<Restaurant>()
                    {
                    new Restaurant(){Name= "Pizza w Dechę", Rating = 5 , EstimatedDeliveryTime = 1.5 , MinOrderAmount = 15.5 , DeliveryCosts = 5 , /*Long = , Lat = , Radius = ,*/ },
                    new Restaurant(){Name= "Pizza 600 stopni", Rating = 4 , EstimatedDeliveryTime = 1.0 , MinOrderAmount = 15.5 , DeliveryCosts = 5 , /*Long = , Lat = , Radius = ,*/ },
                    new Restaurant(){Name= "PizzaPazza", Rating = 4 , EstimatedDeliveryTime = 1.0 , MinOrderAmount = 15.5 , DeliveryCosts = 5 , /*Long = , Lat = , Radius = ,*/ },
                    new Restaurant(){Name= "Red Pub", Rating = 2 , EstimatedDeliveryTime = 1.5 , MinOrderAmount = 15.5 , DeliveryCosts = 5 , /*Long = , Lat = , Radius = ,*/ },
                    new Restaurant(){Name= "DaGrasso", Rating = 4 , EstimatedDeliveryTime = 1.0 , MinOrderAmount = 15.5 , DeliveryCosts = 5 , /*Long = , Lat = , Radius = ,*/ },
                    new Restaurant(){Name= "Stefa Dobrej Pizzy", Rating = 4 , EstimatedDeliveryTime = 1.0 , MinOrderAmount = 15.5 , DeliveryCosts = 5 , /*Long = , Lat = , Radius = ,*/ },
                    new Restaurant(){Name= "Strefa Pizzy", Rating = 3 , EstimatedDeliveryTime = 1.0 , MinOrderAmount = 15.5 , DeliveryCosts = 5 , /*Long = , Lat = , Radius = ,*/ },
                    new Restaurant(){Name= "Tele pizza", Rating = 5 , EstimatedDeliveryTime = 0.5 , MinOrderAmount = 15.5 , DeliveryCosts = 5 , /*Long = , Lat = , Radius = ,*/ },
                    new Restaurant(){Name= "Restauracja Złote Łuki", Rating = 5 , EstimatedDeliveryTime = 1.0 , MinOrderAmount = 5.0 , DeliveryCosts = 7 , /*Long = , Lat = , Radius = ,*/ },
                    new Restaurant(){Name= "KFC", Rating = 3 , EstimatedDeliveryTime = 0.5 , MinOrderAmount = 5.0 , DeliveryCosts = 4 , /*Long = , Lat = , Radius = ,*/ },
                    new Restaurant(){Name= "Cleopatra", Rating = 5, EstimatedDeliveryTime = 1.0 , MinOrderAmount = 25 , DeliveryCosts = 6 , /*Long = , Lat = , Radius = ,*/ },
                    new Restaurant(){Name= "Restauracja pod Ratuszem", Rating = 5, EstimatedDeliveryTime = 1.0 , MinOrderAmount = 20 , DeliveryCosts = 6 , /*Long = , Lat = , Radius = ,*/ }

                    };

                    var menuRestaurants = new List<Meal>()
                    {
                    new Meal(){Name="Burger",Components="Bułka,Mięso wołowe 100%, sałata, pomidor, ogórek, sosy",Price=12, TypeOfFood=typeoffoods[0] },
                    new Meal(){ Name="Zapiekanka",Components="Bułka,szynka,ser,sos",Price=5, TypeOfFood=typeoffoods[5]},
                    };

                    var menus = new List<Menu>()
                    {
                    //new Menu(){ Meals = menuRestaurants },
                    };


                    context.AppUsers.AddRange(users);
                    context.TypeOfFoods.AddRange(typeoffoods);
                    context.CategoryFoods.AddRange(categoryfood);
                    context.Meals.AddRange(meals);
                    context.Restaurants.AddRange(restaurants);
                    //context.Menus.AddRange.(menus);
                    context.SaveChanges();
                }
                catch (Exception  ex)
                {
                }
            }
        }
    }
}
