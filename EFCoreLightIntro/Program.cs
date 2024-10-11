﻿using EFCoreLightIntro.Data;

namespace EFCoreLightIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                // CREATE CREATE CREATE CREATE CREATE CREATE
                // CREATE CREATE CREATE CREATE CREATE CREATE
                // CREATE CREATE CREATE CREATE CREATE CREATE
                var purchase1 = new Purchase()
                {
                    Id = 1,
                    Product = "Playstion 5",
                    Price = 4999m
                };
                
                dbContext.Purchases.Add(purchase1);

                var purchase2 = new Purchase()
                {
                    Id = 2,
                    Product = "XBOX",
                    Price = 4950m
                };

                dbContext.Purchases.Add(purchase2);
                dbContext.SaveChanges();

                // READ ALL READ ALL READ ALL READ ALL READ ALL
                // READ ALL READ ALL READ ALL READ ALL READ ALL
                // READ ALL READ ALL READ ALL READ ALL READ ALL
                var allPurchases = dbContext.Purchases.ToList();
                foreach (var purchase in allPurchases)
                {
                    Console.WriteLine($" Read ALL:\t {purchase.Product}");
                }

                // READ ONE READ ONE READ ONE READ ONE READ ONE
                // READ ONE READ ONE READ ONE READ ONE READ ONE
                // READ ONE READ ONE READ ONE READ ONE READ ONE
                var chosenPurchase = dbContext.Purchases.First(p => p.Id == 1);
                Console.WriteLine($" Read ONE:\t {chosenPurchase.Product}");

                // UPDATE UPDATE UPDATE UPDATE UPDATE UPDATE
                // UPDATE UPDATE UPDATE UPDATE UPDATE UPDATE
                // UPDATE UPDATE UPDATE UPDATE UPDATE UPDATE
                var purchaseToUpdate = dbContext.Purchases.First(p => p.Id == 2);
                purchaseToUpdate.Price = 4800m; // Ändra priset
                dbContext.SaveChanges();

                Console.WriteLine($" Updated:\t {purchaseToUpdate.Product} now costs {purchaseToUpdate.Price}");

                // DELETE DELETE DELETE DELETE DELETE DELETE
                // DELETE DELETE DELETE DELETE DELETE DELETE
                // DELETE DELETE DELETE DELETE DELETE DELETE

                // HOMEWORK!
            }
        }
    }
}
