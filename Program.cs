class Program
{
 
    static void Main(String[] args)
    {
        HaloGeneric<String> sapa = new HaloGeneric<String>();
        sapa.SapaUser("Fazza");

        DataGeneric<String> data = new DataGeneric<String>("103022300062");
        data.printData();
    }
}

class HaloGeneric<X>
{
    public void SapaUser(X user)
    {
        Console.WriteLine($"Halo user {user}");
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