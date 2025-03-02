namespace TaskManagerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task myTask = new Task(1, "TEST", "letsseeee", 5, DateTime.Now.AddDays(5));
            Console.WriteLine(myTask);
        }
    }
}