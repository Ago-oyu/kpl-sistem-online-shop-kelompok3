public class Keranjang<T>
{
    private List<Product<T>> items = new List<Product<T>>();

    public void AddItem(Product<T> product)
    {
        items.Add(product);
    }

    public void RemoveItem(Product<T> product)
    {
        items.Remove(product);
    }

    public void DisplayItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"ID: {item.ID}, Nama: {item.Nama}, Harga: {item.Harga}, Stok: {item.Stok}");
        }
    }
}
