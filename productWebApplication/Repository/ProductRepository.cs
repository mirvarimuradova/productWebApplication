using Microsoft.AspNetCore.Mvc;
using productWebApplication.Models;

namespace productWebApplication.Repository
{
    public class ProductRepository
    {
        private List<Product> products = new List<Product>()
        {
             new Product(){ID = 1, Name = "iPhone 16", Price = 2888, Description = "The latest iPhone model with advanced features.",
                 ImageURL="/Images/iphone-16-0.png"},
            new Product(){ID = 2, Name = "Samsung Galaxy S23", Price = 2499, Description = "High-end smartphone with excellent camera quality.",
               ImageURL="/Images/new-project-s23-6-png.webp" },
            new Product(){ID = 3, Name = "Dell XPS 15", Price = 3500, Description = "Premium laptop for professionals and creators.",
                ImageURL="/Images/Dell XPS 15.jpg"},
            new Product(){ID = 4, Name = "Sony WH-1000XM5", Price = 399, Description = "Noise-cancelling wireless headphones with superior sound.",
            ImageURL="/Images/Sony WH-1000XM5.png"},
            new Product(){ID = 5, Name = "Apple Watch Series 9", Price = 499, Description = "Smartwatch with health tracking and fitness features.",
            ImageURL="/Images/Apple Watch Series 9_.jpg"},
            new Product(){ID = 6, Name = "LG OLED TV 55", Price = 1800, Description = "Ultra-thin 4K OLED TV with stunning visuals.",
            ImageURL="/Images/LG OLED TV 55.webp"},
            new Product(){ID = 7, Name = "Google Pixel 8", Price = 2000, Description = "Google's flagship phone with stock Android experience.",
            ImageURL="/Images/Google Pixel 8.webp"},
            new Product(){ID = 8, Name = "Asus ROG Zephyrus G14", Price = 2200, Description = "Compact gaming laptop with powerful performance.",
            ImageURL="/Images/Asus ROG Zephyrus G14.jpg"},
            new Product(){ID = 9, Name = "Amazon Kindle Paperwhite", Price = 150, Description = "E-reader with adjustable warm light and waterproof design.",
           ImageURL="/Images/Amazon Kindle Paperwhite.jpg" },
            new Product(){ID = 10, Name = "Bose SoundLink Flex", Price = 149, Description = "Portable Bluetooth speaker with deep, rich sound.",
            ImageURL="/Images/Bose SoundLink Flex.jpg"}

        };


        public List<Product> GetProduct()
        {


            return products;    
        }

        public Product GetById(int id)
        {

            return this.products.FirstOrDefault(c => c.ID == id);

        }

    }
}
