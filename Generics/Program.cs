internal class Program
{
    private static void Main(string[] args)
    {
        List<string> sehirler = new List<string>();
        sehirler.Add("ankara");
        sehirler.Add("ankara");
        sehirler.Add("ankara");

        Console.WriteLine("sehirler count: "+sehirler.Count);

        MyList<string> sehirler2 = new MyList<string>();
        sehirler2.Add("kars");
        sehirler2.Add("kars");
        sehirler2.Add("kars");
        sehirler2.Add("kars");

        Console.WriteLine("sehirler2 count: " + sehirler2.Count);

        Console.ReadLine();
    }
}

class MyList<T> //generic class
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)
    {
        _tempArray= _array;
        _array=new T[_array.Length+1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length-1] = item;
    }

    public int Count
    {
        get { return _array.Length; }
    }

}