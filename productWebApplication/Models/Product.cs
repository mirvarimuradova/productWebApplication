namespace productWebApplication.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string ImageURL { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //public Product(int Id, string name, string ImageUrl, string description, decimal price)
        //{
        //    ID = Id;
        //    Name = name;
        //    ImageURL = ImageUrl;
        //    Description = description;
        //    Price = price;

        //}
    }
}
