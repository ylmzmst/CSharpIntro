internal class Program
{
    private static void Main(string[] args)
    {
        //interface new lenemez
        //IPersonManager personManager=new PersonManager();
        //personManager.Add();

        IPersonManager customerManager = new CustomerManager2();
        customerManager.Add();
        customerManager.Update();

        IPersonManager employeeManager = new EmployeeManager();
        employeeManager.Add();
        employeeManager.Update();

        ProjectManager projectManager =new ProjectManager();
        projectManager.Add(customerManager);
        projectManager.Add(employeeManager);
        projectManager.Add(new InternManager());

        Console.ReadLine();
    }
}
class PersonManager
{
    //implemented operation
    public void Add()
    {
        Console.WriteLine("Eklendi");
    }
}

class CustomerManager:PersonManager
{

}

interface IPersonManager
{
    //unimplemented operation
    void Add();
    void Update();
}

class CustomerManager2 : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("müşteri güncellendi");

    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("personel eklendi");
    }

    public void Update()
    {
        Console.WriteLine("personel güncellendi");

    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("stajer eklendi");
    }

    public void Update()
    {
        Console.WriteLine("stajer güncellendi");
    }
}
class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}

