using Project4.Entities;

namespace Project4.DataAccess;

public interface IProductDal
{
    List<Product> GetAll();
}