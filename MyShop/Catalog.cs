namespace MyShop;

public class Catalog: ICatalog
{
    public List<Product> Products = new List<Product>()
    {
        new Product(1,"Phone", 100, new Category("Technology"), new Uri("https://i5.walmartimages.com/asr/10accd37-b241-4d55-b39d-2417f2f80f74.dd8421d47ac8c8517d0b81fe716760b2.jpeg")), 
        new Product(2,"Television", 50, new Category("Technology"), new Uri("https://images.techopedia.com/images/uploads/television.jpg")), 
        new Product(3,"Console", 25, new Category("Technology"), new Uri("https://upload.wikimedia.org/wikipedia/commons/a/ab/Dendy_Junior_with_cart_and_joypads.png")),
        new Product(4, "Milk", 10, new Category("Products"), new Uri("https://images.immediate.co.uk/production/volatile/sites/30/2020/02/Glass-and-bottle-of-milk-fe0997a.jpg?quality=90&resize=960,872")),
        new Product(5, "Tea", 30, new Category("Products"), new Uri("https://img.kavosdraugas.lt/1876391e-f5aa-4e92-bbb1-aeddab6eef5e/470x470/stick-tea-fruit-medleyjpg.jpg")),
        new Product(6, "Chocolate", 40, new Category("Products"), new Uri("data:image/jpeg;base64,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"))
    };

    public List<Category> Categories = new List<Category>()
    {
        new Category("Technology"),
        new Category("Products")
    };

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        Products.Remove(product);
    }

    public Product GetProduct(int id)
    {
        return Products.Find(i => i.Id == id);
    }

    public IReadOnlyList<Product> GetProducts()
    {
        return Products;
    }

    public void AddCategory(Category category)
    {
        Categories.Add(category);
    }

    public void RemoveCategory(Category category)
    {
        Categories.Remove(category);
    }

    public Category GetCategory(string name)
    {
        return Categories.Find(n => n.Name == name);
    }

    public IReadOnlyList<Category> GetCategories()
    {
        return Categories;
    }
}