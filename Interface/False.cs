namespace Interface;

internal interface IPersonManager2
{
    void Add();
    void Update();
}

internal class CustomerManager2 : IPersonManager2
{
    public void Add()
    {
    }

    public void Update()
    {
    }
}

internal class EmployeeManager2 : IPersonManager2
{
    public void Add()
    {
    }

    public void Update()
    {
    }
}

internal class ProjectManager2
{
    public void AddEmployee2(EmployeeManager2 employeeManager2)
    {
    }

    public void AddCustomer2(CustomerManager2 customerManager2)
    {
    }
}

/*
 *Bu şekilde aslında ProjectManager new lenerek iki tane farklı metot çğrılarak verilebilir nesneler -> Program.cs 2
 */