class Program
{
    static void Main()
    {
        for (int i = 10; i >= 0; i--)
        {
            for (int j = 10; j >= i; j--)
            {
                System.Console.Write(j);
                System.Console.Write(" ");
            }
            System.Console.WriteLine();
        }

        System.Console.ReadKey();
    }
}


