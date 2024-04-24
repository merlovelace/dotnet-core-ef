namespace Interface;

internal interface IPersonManager3
{
    void Add();
    void Update();
}

internal class CustomerManager3 : IPersonManager3
{
    public void Add()
    {
    }

    public void Update()
    {
    }
}

internal class EmployeeManager3 : IPersonManager3
{
    public void Add()
    {
    }

    public void Update()
    {
    }
}

internal class InternManager3 : IPersonManager3
{
    public void Add()
    {
    }

    public void Update()
    {
    }
}

internal class ProjectManager3
{
    public void Add3(IPersonManager3 personManager3)
    {
    }
}

// Bunlar interface 'i implamete ediyordu ve implamente edilen interface de iki class'ın da referansını tuutyordu