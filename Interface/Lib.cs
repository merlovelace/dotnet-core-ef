namespace Interface;

//Normal class'lar için biz inherited olayını yapabiliyoruz Manager class'lar için de örn

class PersonManager
{
    public void Add()
    {
        Console.WriteLine("Ekleme yapıldı."); // buradaki scope'a implamented operation denir 
    }
}

// --------Inherits -class 
// class CustomerManager : PersonManager // olduğundan PersonManager sınıfının metodu CustomManager için de kullanılabilmekte
// {
//     
// }

//Interface'lerdeki durum unimplemented, interface üyeleri dışarıdan erişilebilir olmalıdır bu yüzden default public 
// olduğundan bir daha public demeye gerek yok, burada farkı içini doldurmuyorum yani şu demek oluyor 
// Customer için Add ayrı çalışır , Employee için Add ayrı çalışır 


//implements- interface
interface IPersonManager
{
    void Add(); // imza denir, şablon olarak kullanılır 
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        //müşteri ekleme kodları 
        Console.WriteLine("Müşteri ekleme kodları");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //Çalışan ekleme kodları 
        Console.WriteLine("Çalışan ekleme kodları");
    }
}