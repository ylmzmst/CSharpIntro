internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer { ID = 1,FirstName="engin",LastName="demiroğ",City="ankara"};//default constructor

        Customer customer2 = new Customer(2, "derin", "demiroğ", "ankara");//custom constructor

        Console.WriteLine(customer2.FirstName);

        Console.ReadLine();
    }
}

class Customer
{
    //default constructor
    public Customer()
    {
        
    }

    //custom constructor
    public Customer(int id,string firstName,string lastName,string city)
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}