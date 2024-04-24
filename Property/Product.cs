namespace Property;

public class Product
{
    private double _unitPrice; //field
    public int Id { get; set; }
    public string Name { get; set; }

    public double UnitPrice
    {
        get => _unitPrice + _unitPrice * 18 / 100;
        set => _unitPrice = value;
    }
}

//bu sınıfın hep bir column'u bir property