class Program
{
    static void Main()
    {
        //variable to store grade letter of student
        int score = 55;
        char gradeLetter = 'A';
        if (score >= 35)
        {
            if (score > 85)
            {
                gradeLetter = 'O';
            }
            else if (score >= 70 &&  score <= 85) 
            {
                gradeLetter = 'A';
            }

            else if (score >= 50 && score < 70)
            {
                gradeLetter = 'B';
            }
            else if (score > 35  && score < 50)
            {
                gradeLetter = 'C';
            }
        }
        else if(score <= 35)
        {
            gradeLetter = 'F';  
        }
        //find out description based on gradeLetter
        string gradeDescription;
        switch(gradeLetter)
        {
            case 'O': gradeDescription = "Outstanding"; 
                break;
            case 'A': gradeDescription = "Excellent"; 
                break;
            case 'B': gradeDescription = "Good"; 
                break;
            case 'C': gradeDescription = "Average"; 
                break;
            case 'F': gradeDescription = "Fail"; 
                break;
            default: gradeDescription = "None"; 
                break;
        }
        System.Console.WriteLine(gradeDescription);
        System.Console.ReadKey();
    }
}
