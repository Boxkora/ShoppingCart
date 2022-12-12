using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Infrastructure
{
        public class SeedData
        {
                public static void SeedDatabase(DataContext context)
                {
                        context.Database.Migrate();

                        if (!context.Products.Any())
                        {
                                Category Ffruits = new Category { Name = "Functional Fruits", Slug = "fruits" };
                                Category nmedicine = new Category { Name = "Nutritional Medicine", Slug = "nmedicine" };

                                context.Products.AddRange(
                                        new Product
                                        {
                                                Name = "Apples",
                                                Slug = "apples",
                                                Description = "Juicy apples",
                                                Price = 1.00M,
                                                Category = Ffruits,
                                                Image = "apple.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Bananas",
                                                Slug = "bananas",
                                                Description = "Fresh bananas",
                                                Price = 0.30M,
                                                Category = Ffruits,
                                                Image = "banana.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Kiwi",
                                                Slug = "kiwi",
                                                Description = "Juicy kiwi",
                                                Price = 0.50M,
                                                Category = Ffruits,
                                                Image = "kiwi.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Carrot",
                                                Slug = "carrot",
                                                Description = "Juicy carrot",
                                                Price = 0.20M,
                                                Category = Ffruits,
                                                Image = "carrot.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Natural Fish Oil",
                                                Slug = "natural-fish-oil",
                                                Description = "Good for health",
                                                Price = 5.99M,
                                                Category = nmedicine,
                                                Image = "nfishoil.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Omega Fish Oil",
                                                Slug = "omega-fish-oil",
                                                Description = "Good for health",
                                                Price = 7.99M,
                                                Category = nmedicine,
                                                Image = "ofishoil.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "BlackMores Fish Oil",
                                                Slug = "blackMores-fish-oil",
                                                Description = "Good for health",
                                                Price = 11.99M,
                                                Category = nmedicine,
                                                Image = "bmfishoil.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Kirk Fish Oil",
                                                Slug = "kirk-fish-oil",
                                                Description = "Good for health",
                                                Price = 12.99M,
                                                Category = nmedicine,
                                                Image = "kirkfishoil.jpg"
                                        }
                                );

                                context.SaveChanges();
                        }
                }
        }
}