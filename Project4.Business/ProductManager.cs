using Project4.DataAccess;
using Project4.Entities;

namespace Project4.Business;

public class ProductManager
{
    public List<Product> GetAll()
    {
        ProductDal productDal = new ProductDal( );
        
        //İş kodları yazılır 
        return productDal.GetAll();
    }
}