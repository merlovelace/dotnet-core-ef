namespace Property;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double UnitPrice
    {
        get { return _unitPrice + _unitPrice * 18 / 100; }
        set { _unitPrice = value;  }

    }
    private double _unitPrice; //field
}

//bu sınıfın hep bir column'u bir property