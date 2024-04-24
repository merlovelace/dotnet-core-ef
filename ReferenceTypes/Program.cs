using ReferenceTypes;

var person = new Person
{
    Id = 1,
    FirstName = "Merve",
    LastName = "Yolcu"
};


var customer = new Customer
{
    Id = 2,
    FirstName = "Ahmet",
    LastName = "Dok",
    CreditCard = 34343223
};

Person person2 = customer;
customer.Id = 3;
Console.WriteLine(person2.Id);
Console.WriteLine(customer.Id);

var personManager = new PersonManager();
personManager.Add(customer);
personManager.Add(person2);

/*
 * Burada gördüğümüz gibi her class için ayrı ayrı fonskyion yazmak yerine her classın bir base i oluştuurlursa ve
 * o base 'e bir manager eklenirse o zaman bir classManager ile işi bitirmiş oluruz
 *
 */