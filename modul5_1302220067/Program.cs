internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<int>(13, 02, 22));

        var database = new SimpleDataBase<int>();
        database.AddNewData(12);
        database.AddNewData(02);
        database.AddNewData(22);

        database.PrintAllData();
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
class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data {0} berisi: {1}, yang disimpan pada waktu UTC: {2}", i + 1, storedData[i], inputDates[i]);
        }
    }
}