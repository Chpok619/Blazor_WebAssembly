namespace MyShop;

public interface ICatalog
{
    void AddProduct(Product product);
    void RemoveProduct(Product product);
    Product GetProduct(int id);
    IReadOnlyList<Product> GetProducts();

    void AddCategory(Category category);
    void RemoveCategory(Category category);
    Category GetCategory(string name);
    IReadOnlyList<Category> GetCategories();
}