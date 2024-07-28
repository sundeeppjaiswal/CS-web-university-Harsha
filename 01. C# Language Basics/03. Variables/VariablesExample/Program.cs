class Sample
{
    static void Main()
    {
        //declare the variable and it stored in STACK memory(RAM)
        string studentName = "Sundeep";
        int age = 30;

        //print value
        System.Console.Write("Hey ");
        System.Console.Write(studentName);
        System.Console.Write(", your age is ");
        System.Console.WriteLine(age);

        //Concating the sentence
        System.Console.WriteLine("Hey " + studentName + ", your age is " + age);

        //wait for pressing some key on keyboard
        System.Console.ReadKey();
    }
}