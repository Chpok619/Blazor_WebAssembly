namespace MyShop;

public class CartForShop: ICartForShop
{
    private List<Product> Products;

    public CartForShop()
    {
        Products = new List<Product>();
    }
    
    public void AddToCart(Product product)
    {
        Products.Add(product);
    }

    public void RemoveFromCart(Product product)
    {
        Products.Remove(product);
    }

    public IReadOnlyList<Product> GetCart()
    {
        return Products;
    }

    public void RemoveAllProducts()
    {
        Products = new List<Product>();
    }
}