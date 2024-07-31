class Student
{
    //public field
   public int grade = 0;

    //public method
    public void PrintGrade(int grade = 2) // default argument
    {
        System.Console.WriteLine("Grade: " + grade);
    }

    //public method with ref return
    public ref int DoWork()
    {
        //return reference of 'grade' field
        return ref grade;
    }

    public ref int AddWork() { return ref grade; }
}

class Program
{
    static void Main()
    {
        //creating object of Student
        Student s = new Student();

        //call PrintGrade
        s.PrintGrade();

        //call DoWork
        ref int g = ref s.DoWork();
        ref int h = ref s.AddWork();
        //update the value of 'ref return'
        g = 5;
        h= 10;
        //call PrintGrade after updating the value of 'ref return'
        s.PrintGrade(5); //Output: 5
        s.PrintGrade(10);

        System.Console.ReadKey();
    }
}
