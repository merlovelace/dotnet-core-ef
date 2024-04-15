namespace Classes2;

//Class içerisine sadece özelliklerini değil fonksiyonlarını(metotlarını) da ekleyebiliriz

//reusability
public class ProductManager
{
    public void Add()
    {
        Console.WriteLine("Ürün eklendi.");
    }

    public void Add(Product product)
    {
        Console.WriteLine("Product tipinde ürün eklendi.");
    }
}