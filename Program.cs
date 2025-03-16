class Program
{
    static void Main(String[] args)
    {
        HaloGeneric<String> sapa = new HaloGeneric<String>();
        sapa.SapaUser("Fazza");
    }
}

class HaloGeneric<X>
{
    public void SapaUser(X user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}