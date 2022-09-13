internal class Program
{
    private static void Main(string[] args)
    {
        int pas = 1234;
        string name = "gggg";
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Введите имя:");
            string f = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            int g = int.Parse(Console.ReadLine());
            if (g == pas && f == name)

            {
                Console.WriteLine();
                Console.WriteLine("Enter the System");
                break;
            
            }

        }
        Console.WriteLine();
        Console.WriteLine("The number of available tries have been exceeded");



    }
}