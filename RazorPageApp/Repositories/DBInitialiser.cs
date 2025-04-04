using RazorPageApp.Models;

namespace RazorPageApp.Repositories
{
    public static class DBInitialiser
    {
        private const string ImagesFolderPath = "wwwroot/images";
        public static void Initialise(ProductContext context)
        {
            context.Database.EnsureCreated();

            //SeedInitialProducts(context);

            CreateProductsFromImages(context, ImagesFolderPath);
            
           
        }

        private static void CreateProductsFromImages(ProductContext context, string imagesFolderPath)
        {
            if (!Directory.Exists(imagesFolderPath)) return;

            var imageFiles = Directory
                .EnumerateFiles(imagesFolderPath, ".", SearchOption.TopDirectoryOnly)
                .Where(file => file.EndsWith(".jpg") || file.EndsWith(".jpeg") || file.EndsWith(".png"))
                .ToList();

            foreach(var imagePath in imageFiles)
            {
                var imageFilename = Path.GetFileName(imagePath);

                bool productExists = context.Products.Any(p => p.ImageURL == imageFilename);
                if (!productExists)
                {
                    var newProduct = new ProductModel
                    {
                        Name = imageFilename,
                        Code = "AUTO -" + imageFilename,
                        ImageURL = imageFilename,
                        Category = "Misc",
                        Stock = 10,
                        Description = "This is automaticlaly generated product from image folder.",
                        Weight = "N/A",
                        Price = 0.00m
                    };
                    context.Products.Add(newProduct);
                }
            }
            context.SaveChanges();
        }

        /*private static void SeedInitialProducts(ProductContext context)
        {
            if (context.Products.Any())
            {
                return;
            }

            var products = new ProductModel[]
            {
                new ProductModel()
                {
                    Name = "Apples",
                    Code = "AB123",
                    ImageURL = "apples.jpg",
                    Category = "Fruit",
                    Stock = 20,
                    Description = "Healthy Juicy Apples!",
                    Weight = "50kg",
                    Price = 0.90m
                },
                new ProductModel()
                {
                    Name = "Eggs",
                    Code = "AB124",
                    ImageURL = "eggs.png",
                    Category = "Dairy",
                    Stock = 50,
                    Description = "Free Range Eggs!",
                    Weight = "50kg",
                    Price = 1m
                }
                ,
                new ProductModel()
                {
                    Name = "Golden Bun",
                    Code = "AB125",
                    ImageURL = "goldenbun.jpg",
                    Category = "Bakery",
                    Stock = 50,
                    Description = "Warm Soft Bread!",
                    Weight = "50kg",
                    Price = 0.90m
                }
                ,
                new ProductModel()
                {
                    Name = "Milk 1L",
                    Code = "AB126",
                    ImageURL = "milk.png",
                    Category = "Dairy",
                    Stock = 70,
                    Description = "Cold Delicious Milk!",
                    Weight = "50kg",
                    Price = 1.90m
                }
                ,
                new ProductModel()
                {
                    Name = "Pizza",
                    Code = "AB127",
                    ImageURL = "pizza.jpg",
                    Category = "Frozen",
                    Stock = 60,
                    Description = "Delicious Pizza!",
                    Weight = "50kg",
                    Price = 5.30m
                }
                ,
                new ProductModel()
                {
                    Name = "Sausage-Rolls",
                    Code = "AB128",
                    ImageURL = "sausage-rolls.jpeg",
                    Category = "Bakery",
                    Stock = 30,
                    Description = "Savoury Sausage Rolls!",
                    Weight = "50kg",
                    Price = 3.50m
                }
            };
            foreach (ProductModel p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();
        }*/
    }
}
