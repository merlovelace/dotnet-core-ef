namespace AccessModifier;

public class Customer
{
    public int Id { get; set; }
    protected string FirstName { get; set; }

    public void  CustomerTest()
    {
        FirstName = "merve"; //PROTECTED KENDİ KLASINDA VE KENDİ CLASSINI INHERİT EDEN CLASSLARDA 
    }
}

//Bir class ın default u bir internal'dir , ve yazıldığı projede her yerden erişilebilir başında internal veya public olsun olmasın , başka projeden ulaşmak istersem başına 
//PUBLİC ekliyorum

/*
 Bir class public oldu diye başka projelerden erişilebilir ama eğer bir porperty'nin başında public yazmazsa ve direkt type değeriyle başlarsa o zaman
 o class ın ait olduğu yerde property kullanılabilirken , başka projeden erişimi olmaz , istediği kadar class public olsun
 */

public class CustomerTest: Customer
{
    public void Test()
    {
        FirstName = "merve";
    }
}