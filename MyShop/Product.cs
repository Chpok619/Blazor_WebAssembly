namespace MyShop;
public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public  int Price { get; set; }
    public  Category Category { get; set; }
    public Uri Image { get; set; }
    public Product(int id,string name, int price, Category category, Uri image)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
        Image = image;
    }
}