internal class Program
{
    private static void Main(string[] args)
    {
        var database = new SimpleDataBase<int>();
        database.AddNewData(12);  
        database.AddNewData(02);
        database.AddNewData(22);

        database.PrintAllData();
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