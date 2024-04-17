/*
 Constructor -> Bir class new 'lendiğinde çalışan bloktur , ilk oluştuğu zaman bir kez çalışır ve daha sonra çalışmaz
 Constructor bir metot gibi çalışır
 */


internal class Customer
{
    //Default Constructor
    public Customer()
    {
    }

    public Customer(int id, string name, string lastName,
        string city) //Sanki bir metot gibi ama herhangi bir şey dönmeyen bir yapıda 
    {
        Id = id;
        Name = name;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}

//Customer customer = new Customer(); //Burada yeni bir instance oluşur ama console'landığında herhangi bir şey vermez
//Customer customer2 = new Customer() { Id = 1, Name = "Merve", LastName = "Yolcu", City = "İstanbul" }; //Böylelikle default constructor çalışır
//Customer customer3 = new Customer(2,"Ahmet","Dok","Jakarta"); //metot mantığında çalışırlar 