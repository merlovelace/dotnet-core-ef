/*
 * Miras
 *Bir class içerisinde özellik ve metotlar bulunabilmekte ve eğer
 *
 */

class PersonManager
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public void Add()
    {
        Console.WriteLine("Ekleme yapıldı'");
    }

    public void Delete()
    {
        Console.WriteLine("Silindi!");
    }
}

//Eğer ben Person class'ının metotlarının Person ın bir kolu olan çalışanda yapabilsin istiyorsam 

class EmployeeManager : PersonManager //İşte burada artık Employee de Add ve Delete yapabilmekte ben bir daha gidip aynılarını bu class 'a yazmama gerek yok
{
    public int EmployeeId { get; set; }
}

class CustomerManager : PersonManager
{
    public void GetBestCustomer()
    {
        Console.WriteLine("Ayın müşterisi!"); // Bu sadece Customer' a ait 
    }
}


// PersonManager personManager = new PersonManager();
// personManager.Add();
//
// CustomerManager customerManager = new CustomerManager();
// customerManager.GetBestCustomer();
// customerManager.Add();

// EmployeeManager employeeManager = new EmployeeManager();
// employeeManager.Name = "Merve";
// employeeManager.EmployeeId = 4;

