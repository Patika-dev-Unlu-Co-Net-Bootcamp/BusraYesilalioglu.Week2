using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;


namespace UnluCo.Week1.HomeWork.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CatStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<CatStoreDbContext>>()))
            {
                if (context.Catz.Any())
                {
                    return;
                }
                context.Catz.AddRange(  // Database'e verilerin eklenmesi

                new Cats
                {
                    // Id = 1,
                    Name = "Arya",
                    Breed = "British Shorthair",
                    GenderId = 1,
                    Age = 2,
                    Color = "Siyah",
                    DateOfBirth = new DateTime(2020, 11, 27)


                },
                new Cats
                {
                    // Id = 2,
                    Name = "Oscar",
                    Breed = "British Shorthair",
                    GenderId = 2,
                    Age = 0.6,
                    Color = "Gri-Beyaz-Siyah",
                    DateOfBirth = new DateTime(2021, 06, 29)

                },
                new Cats
                {
                    // Id = 3,
                    Name = "Pamir",
                    Breed = "British Shorthair",
                    GenderId = 2,
                    Age = 0.6,
                    Color = "Gri",
                    DateOfBirth = new DateTime(2021, 06, 29)

                },
                new Cats
                {
                    // Id = 4,
                    Name = "Tarçın",
                    Breed = "British Shorthair",
                    GenderId = 2,
                    Age = 0.6,
                    Color = "Kahverengi-Beyaz",
                    DateOfBirth = new DateTime(2021, 06, 29)

                },
                new Cats
                {
                    // Id = 5,
                    Name = "Mia",
                    Breed = "British Shorthair",
                    GenderId = 1,
                    Age = 0.6,
                    Color = "Beyaz-Siyah",
                    DateOfBirth = new DateTime(2021, 06, 29)

                }
                );
                context.SaveChanges();

            }
            
        }
        public static List<User> Userz = new List<User>
        {
            new User
            {
                UserEmail= "admin@admin",
                UserPassword = "admin1234"
            }


        };
    }
}