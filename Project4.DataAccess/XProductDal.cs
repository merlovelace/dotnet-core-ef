using Project4.Entities;

namespace Project4.DataAccess;

public class XProductDal : IProductDal
{
     List<Product> _products;

     public XProductDal()
     {
          _products = new List<Product>
          {
               new()
               {
                    ProductId = 1, ProductName = "Acer N Bilgisayar", QuantityPerUnit = "32Gb Ram", UnitPrice = 100000,
                    UnitsInStock = 2
               },
               new()
               {
                    ProductId = 2, ProductName = "Asus N Bilgisayar", QuantityPerUnit = "32Gb Ram", UnitPrice = 100000,
                    UnitsInStock = 1
               },
               new()
               {
                    ProductId = 3, ProductName = "Hp N  Bilgisayar", QuantityPerUnit = "32Gb Ram", UnitPrice = 100000,
                    UnitsInStock = 0
               },
               new()
               {
                    ProductId = 4, ProductName = "Mac N  Bilgisayar", QuantityPerUnit = "32Gb Ram", UnitPrice = 100000,
                    UnitsInStock = 3
               },
               new()
               {
                    ProductId = 5, ProductName = "Dell N Bilgisayar", QuantityPerUnit = "32Gb Ram", UnitPrice = 100000,
                    UnitsInStock = 10
               }

          };
     }

     public List<Product> GetAll()
     {
          return _products;
     }
    
}