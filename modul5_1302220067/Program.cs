internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<int>(13, 02, 22));
    }
}

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T bil1, T bil2, T bil3)
    {
        dynamic hasil1 = bil1;
        dynamic hasil2 = bil2;
        dynamic hasil3 = bil3;

        return hasil1 + hasil2 + hasil3;
    }
}