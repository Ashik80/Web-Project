using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using web_project.Models;

namespace web_project.Data
{
    public class Seed
    {
        public static async Task SeedData(DataContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!context.Products.Any())
            {
                var products = new List<Product>
                {
                    new Product
                    {
                        Name = "Carrot",
                        Category = Category.Vegetable,
                        Quantity = 5,
                        Price = 40,
                        Image = "download.jpg"
                    },
                    new Product
                    {
                        Name = "Chicken",
                        Category = Category.Meat,
                        Quantity = 10,
                        Price = 230,
                        Image = "download (1).jpg"
                    },
                    new Product
                    {
                        Name = "Mango",
                        Category = Category.Fruit,
                        Quantity = 7,
                        Price = 60,
                        Image = "images.jpg"
                    }
                };

                await context.Products.AddRangeAsync(products);
                await context.SaveChangesAsync();
            }

            if (!context.Roles.Any())
            {
                var roles = new List<IdentityRole>
                {
                    new IdentityRole
                    {
                        Name = "Admin"
                    },
                    new IdentityRole
                    {
                        Name = "Customer"
                    },
                    new IdentityRole
                    {
                        Name = "Support"
                    },
                    new IdentityRole
                    {
                        Name = "Delivery"
                    }
                };

                foreach (var role in roles)
                {
                    await roleManager.CreateAsync(role);
                }
            }

            if (!context.Users.Any())
            {
                var rio = new User
                {
                    FirstName = "Rahobar",
                    LastName = "Rio",
                    Email = "rahobar123@gmail.com",
                    UserName = "rahobar123@gmail.com"
                };

                var muhit = new User
                {
                    FirstName = "Abdullah",
                    LastName = "Muhit",
                    Email = "muhitmridul74@gmail.com",
                    UserName = "muhitmridul74@gmail.com"
                };

                var delivery = new User
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "johndoe@gmail.com",
                    UserName = "johndoe@gmail.com"
                };

                await userManager.CreateAsync(rio, "StrongP@ssw0rd");
                await userManager.AddClaimAsync(rio, new Claim("Name", rio.FirstName));
                await userManager.AddToRoleAsync(rio, "Admin");

                await userManager.CreateAsync(muhit, "StrongP@ssw0rd");
                await userManager.AddClaimAsync(muhit, new Claim("Name", muhit.FirstName));
                await userManager.AddToRoleAsync(muhit, "Support");

                await userManager.CreateAsync(delivery, "StrongP@ssw0rd");
                await userManager.AddClaimAsync(delivery, new Claim("Name", delivery.FirstName));
                await userManager.AddToRoleAsync(delivery, "Delivery");
            }
        }
    }
}