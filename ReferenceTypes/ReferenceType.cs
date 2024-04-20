namespace ReferenceTypes;

/*
 * int, decimal, float, enum , boolean bunlar değer(value) tiptir ve sayısal verilerldir
 *Bir mallock çağrısı yapıldığıında stack'te yer ayrılır , değer tipler için her zman stack'de kalıyor
 *
 * array, class, interface.... reference type'dır ve bu sefer değer tutulmaz , reference tutulur
 * burada tanımlama alanında yani mallock çağrılarında her zaman stack işin içindedir ama reference tiplerde heap'de varıdr
 *
 * diyelim ki int[] sayilar = new int[]{} denildiğinde stack içerisinde sayilar oluşur ve heap alanında da referance ı oluşuyor ve birbirlerini adres kodları üzerinden
 * tanıyorlar
 *
 *
 *
 */

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class Employee : Person
{
    public int EmployeeNo { get; set; }
}

public class Customer : Person
{
    public int CreditCard { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}