class Program
{
    static void Main()
    {
        //declare variable to store marks of the student
        int marks = 45;

        //show congratulations if the student has passed
        if (marks >= 35)
        {
            if (marks <= 100)
            System.Console.WriteLine("Congratulations, you scored: " + marks);
        }

        System.Console.ReadKey();
    }
}
