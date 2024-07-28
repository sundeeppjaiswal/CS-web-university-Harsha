/*
Write a program to findout "category of height" based on the given height of a person (in inches), using "if".
Height categories:
Height is less than 150 cm = "Dwarf"
Height is between 150 cm and 165 cm = "Average height"
Height is between 165 cm and 195 cm = "Tall"
Height is above 195 cm = "Abnormal height"

Note: 1 inch = 2.54 centimeter

Eg:
Input: 75
Output: Tall
*/
class Program
{
    static void Main()
    {
        int height_in_inches = 75;  //input
        double height_in_cm = height_in_inches * 2.54;  //1 inch = 2.54 centimeter
        string result = null;  //initialize the 'result' variable

        //check the height and find the height category accordingly
        if (height_in_cm < 150)
            result = "Dwarf";
        else if (height_in_cm >= 150 && height_in_cm <= 165)
            result = "Average height";
        else if (height_in_cm > 165 && height_in_cm <= 195)
            result = "Tall";
        else
            result = "Abnormal height";

        System.Console.WriteLine(result); //Eg output: Tall
        System.Console.ReadKey();
    }
}