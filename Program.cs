namespace QueueAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueExample obj = new QueueExample();
            obj.enqueData(56);
            obj.enqueData(30);
            obj.enqueData(70);

            obj.DisplayData();
        }
    }
}