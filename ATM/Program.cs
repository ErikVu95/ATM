namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("Welcome to my ATM Machine\n");
                var methods = new Methods();
                methods.Login();
            }
    }
}