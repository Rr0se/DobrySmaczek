using DobrySmaczek.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<DataBaseContext>();
            context.Database.EnsureCreated();
            if (!context.Users.Any())
            {
                try
                {
                    var users = new List<User>()
                    {
                        new User(){FirstName = "Jan", LastName = "Kowalski", UserName = "JaKowal" , Email = "JanKowalski@gmail.com", PhoneNumber = "123456789", Adress = "42-200 Częstochowa ul. Waszyngtona 16", Users=Users.User } ,
                        new User(){FirstName = "Anna", LastName = "Lubińska", UserName = "Lubi" , Email = "AnnaLubi@gmail.com", PhoneNumber = "555444333", Adress = "42-200 Częstochowa ul. NMP 18/3", Users=Users.User  } ,
                        new User(){FirstName = "Marta", LastName = "Mazurkiewicz", UserName = "Mazur" , Email = "Marta.Mazurkiewicz94@gmail.com", PhoneNumber = "333666555", Adress = "42-200 Częstochowa ul. Pow 32/9", Users=Users.User  } ,
                        new User(){FirstName = "Marcin", LastName = "Starostecki", UserName = "Stary" , Email = "Marcin_Starostec@gmail.com", PhoneNumber = "222333444", Adress = "42-256 Olsztyn ul. Polna 16", Users=Users.User  } ,
                        new User(){FirstName = "Paweł", LastName = "Stryjewski", UserName = "Stryju" , Email = "PawelStryju@gmail.com", PhoneNumber = "777555444", Adress = "42-200 Częstochowa ul. Pow 32/9", Users=Users.User  } ,
                        new User(){FirstName = "Damian", LastName = "Wiewióra", UserName = " Wiewiórka" , Email = "Damian_Wiewiora@gmail.com", PhoneNumber = "999777666", Adress = "42-200 Częstochowa ul. Wolności 33/2", Users=Users.User  } ,
                        new User(){FirstName = "Alex", LastName = "Mazurkiewicz", UserName = "MłodyMazur" , Email = "AlexMazur@gmail.com", PhoneNumber = "666544455", Adress = "42-200 Częstochowa ul. Pow 32/9", Users=Users.User  } ,
                        new User(){FirstName = "Krystyna", LastName = "Gonera", UserName = "Gonerka" , Email = "KrystynaGonera45@gmail.com", PhoneNumber = "898070505", Adress = "42-200 Częstochowa ul. Spadzista 21", Users=Users.User  } ,
                        new User(){FirstName = "Krzysztof", LastName = "Jaszczołt", UserName = "Jaszczołcik999" , Email = "KrzysiuJaszcz@gmail.com", PhoneNumber = "674839475", Adress = "42-200 Częstochowa ul. Główna 46", Users=Users.User  } ,
                        new User(){FirstName = "Adrianna", LastName = "Jeznach", UserName = "AdriannaJ123" , Email = "JeznachAdrianna@gmail.com", PhoneNumber = "930485748", Adress = "42-200 Częstochowa ul. Prusa 12/1", Users=Users.User  } ,
                        new User(){FirstName = "Michał", LastName = "Prosiak", UserName = "Świnka_1" , Email = "Prosiaczek123@gmail.com", PhoneNumber = "853847323", Adress = "42-200 Częstochowa ul. Kędzierzyńska 1a", Users=Users.User  }

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

                    var meals = new List<Meal>()
                    {
                        new Meal(){Name="Burger",Components="Bułka,Mięso wołowe 100%, sałata, pomidor, ogórek, sosy",Price=12.0, TypeOfFoods=TypeOfFoods.Burgery },
                        new Meal(){ Name="Zapiekanka",Components="Bułka,szynka,ser,sos",Price=5.0, TypeOfFoods=TypeOfFoods.Zapiekanki},
                        new Meal(){ Name="Sałatka Grecka",Components="Sałata,Pomidor,Ogórek,Oliwki,Cebula,Ser Feta",Price=10, TypeOfFoods=TypeOfFoods.Sałatki},
                        new Meal(){ Name="Pizza Capriciosa",Components="Ciasto,Sos,Ser,Szybka,Pieczarki",Price=22, TypeOfFoods=TypeOfFoods.Pizza},
                        new Meal(){ Name="Shoarma Klasyczna",Components="Pierś z kurczaka,Frytki,Pita,Zestaw surówek",Price=20, TypeOfFoods=TypeOfFoods.Dania_Główne},
                        new Meal(){ Name="Filet z Puree",Components="Filet z kurczaka, Puree ziemniaczane, zestaw surówek",Price=15, TypeOfFoods=TypeOfFoods.Dania_Główne},
                        new Meal(){ Name="Grochówka",Components="Zupa: groch,ziemniaki, marchew, pietruszka",Price=5, TypeOfFoods=TypeOfFoods.Zupy},
                        new Meal(){ Name="Chlebek Czosnkowy",Components="Chlebek, masło, czosnek",Price=5, TypeOfFoods=TypeOfFoods.Przystawki},
                        new Meal(){ Name="Sernik",Components="Sernik z rodzynkami, polewa czekoladowa",Price=8, TypeOfFoods=TypeOfFoods.Desery},
                        new Meal(){ Name="Pierogi z mięsem",Components="Pierogi z mięsem, cebula zasmażana",Price=10, TypeOfFoods=TypeOfFoods.Pierogi},
                        new Meal(){ Name="Naleśniki ze szpinakiem",Components="Naleśniki, farsz szpinakowy, sos śmietanowy",Price=10, TypeOfFoods=TypeOfFoods.Naleśniki}
                    };


                    
                    context.Users.AddRange(users);
                    context.Restaurants.AddRange(restaurants);
                    context.Meals.AddRange(meals);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
