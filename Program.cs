class Program
{
    public static void Main(String[] args)
    {
        DataGeneric<String> data = new DataGeneric<String>("103022300062");
        data.printData();
    }
}

class DataGeneric<T>
{
    T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}