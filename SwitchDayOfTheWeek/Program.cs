using System;

class Program
{
    static void Main()
    {
        Console.Write("What day of the week is it? ");

        string dayOfTheWeek = Console.ReadLine();

        switch (dayOfTheWeek)
        {
            case "Monday":
                Console.WriteLine("Just another manic Monday...I wish it were Sunday");
                break;
            case "Tuesday":
                Console.WriteLine("Taco Tuesday!!!");
                break;
            case "Wednesday":
                Console.WriteLine("Humpday");
                break;
            case "Thursday":
                Console.WriteLine("Throwback Thursday");
                break;
            case "Friday":
                Console.WriteLine("TGIF");
                break;
            case "Saturday":
                Console.WriteLine("Surreal Saturday");
                break;
            case "Sunday":
                Console.WriteLine("Get ready for Monday!");
                break;

            default:
                Console.WriteLine("Enter a valid input");
                break;

        }
    }
}
